using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CateringBackend.Users.Client.Commands
{
    public class AddComplaintCommand
    {
        public string Complain_description { get; set; }
    }

    public class AddComplaintCommandWithClientId : AddComplaintCommand, IRequest<(bool orderExists, bool complaintAdded)>
    {
        public Guid ClientId { get; set; }
        public Guid OrderId { get; set; }

        public AddComplaintCommandWithClientId(AddComplaintCommand command, Guid clientId, Guid orderId)
        {
            Complain_description = command.Complain_description;
            ClientId = clientId;
            OrderId = orderId;
        }
    }

    public class AddComplaintCommandWithClientIdHandler : IRequestHandler<AddComplaintCommandWithClientId, (bool orderExists, bool complaintAdded)>
    {
        private readonly CateringDbContext _dbContext;

        public AddComplaintCommandWithClientIdHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<(bool orderExists, bool complaintAdded)> Handle(AddComplaintCommandWithClientId request, CancellationToken cancellationToken)
        {
            if (!_dbContext.Orders.Where(o => o.ClientId == request.ClientId).Any(o => o.Id == request.OrderId)) 
                return (orderExists: false, complaintAdded: false);

            _dbContext.Complaints.Add(Complaint.Create(request.OrderId, request.Complain_description, DateTime.Now));
            await _dbContext.SaveChangesAsync(cancellationToken);

            return (orderExists: true, complaintAdded: true);
        }
    }
}
