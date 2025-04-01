using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Entities.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Commands
{
    public class AddOrderCommand
    {
        public Guid[] DietIDs { get; set; }
        public DeliveryDetailsDTO DeliveryDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class AddOrderCommandWithClientId : IRequest<string>
    {
        public Guid ClientId { get; set; }
        public Guid[] DietIDs { get; set; }
        public DeliveryDetailsDTO DeliveryDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public AddOrderCommandWithClientId() { }
        public AddOrderCommandWithClientId(AddOrderCommand addOrderCommand, Guid clientId)
        {
            ClientId = clientId;
            DietIDs = addOrderCommand.DietIDs == null ? new Guid[0] : addOrderCommand.DietIDs[..];
            DeliveryDetails = addOrderCommand.DeliveryDetails;
            StartDate = addOrderCommand.StartDate;
            EndDate = addOrderCommand.EndDate;
        }
    }

    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommandWithClientId, string>
    {
        private readonly CateringDbContext _dbContext;

        public AddOrderCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Handle(AddOrderCommandWithClientId request, CancellationToken cancellationToken)
        {
            if (request.EndDate <= request.StartDate ||
                request.StartDate <= DateTime.Now)
                return null;

            if (CheckDietIDsNotExists(request.DietIDs) ||
                request.DietIDs.Length == 0)
                return null;

            var addressInDB = await GetDeliveryAddressForOrder(request);
            var dietsInOrder = _dbContext.Diets.Where(d => request.DietIDs.Contains(d.Id)).ToList();
            var orderToAdd = new Order
            {
                Id = Guid.NewGuid(),
                Status = OrderStatus.WaitingForPayment,
                ClientId = request.ClientId,
                CommentForDeliverer = request.DeliveryDetails.CommentForDeliverer,
                DeliveryAddressId = addressInDB.Id,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Price = AccumulateDietsPrice(dietsInOrder) * (int)(request.EndDate - request.StartDate).TotalDays,
                Diets = new HashSet<Diet>(dietsInOrder)
            };

            _dbContext.Orders.Add(orderToAdd);
            await _dbContext.SaveChangesAsync();

            return orderToAdd.Id.ToString();
        }

        private async Task<Address> GetDeliveryAddressForOrder(AddOrderCommandWithClientId request)
        {
            Address addressInDB = default;
            if (request.DeliveryDetails.Address == null)
            {
                addressInDB = await GetClientAddress(request.ClientId);
            }
            else
            {
                addressInDB = await SearchForAddressInDatabase(request.DeliveryDetails.Address);
                if (addressInDB == default)
                {
                    addressInDB = AddressDTO.CreateAddressFromDTO(request.DeliveryDetails.Address);
                    _dbContext.Addresses.Add(addressInDB);
                }
            }
            return addressInDB;
        }

        private async Task<Address> GetClientAddress(Guid clientId) => await
            _dbContext.Addresses.FirstOrDefaultAsync(a => a.Id == _dbContext.Clients.First(c => c.Id == clientId).AddressId);
        
        private bool CheckDietIDsNotExists(Guid[] DietIDs) =>
            DietIDs.Any(id => !_dbContext.Diets.Where(d => d.IsAvailable).Any(d => d.Id == id));

        private async Task<Address> SearchForAddressInDatabase(AddressDTO addressDTO) => await
            _dbContext.Addresses.FirstOrDefaultAsync(a => 
                a.Street == addressDTO.Street &&
                a.BuildingNumber == addressDTO.BuildingNumber &&
                a.ApartmentNumber == addressDTO.ApartmentNumber &&
                a.PostCode == addressDTO.PostCode && 
                a.City == addressDTO.City
            );

        private decimal AccumulateDietsPrice(List<Diet> dietsInOrder) => dietsInOrder.Sum(d => d.Price);
    }
}