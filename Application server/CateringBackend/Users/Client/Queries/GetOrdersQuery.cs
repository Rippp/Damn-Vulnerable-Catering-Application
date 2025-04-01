using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Domain.Entities.Enums;
using CateringBackend.Meals;
using CateringBackend.Search;
using CateringBackend.Utilities.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Queries
{
    public class GetOrdersQuery : BaseSearchQuery<Order>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Price { get; set; }
        public int? Price_lt { get; set; }
        public int? Price_ht { get; set; }
        public OrderStatus? Status { get; set; }

        public GetOrdersQuery() { }
        protected override IQueryable<Order> GetFiltered(IQueryable<Order> collectionToFilter)
        {
            throw new NotImplementedException();
        }
        protected override IQueryable<Order> GetSorted(IQueryable<Order> collectionToSort)
        {
            throw new NotImplementedException();
        }
    }

    public class GetOrdersQueryWithUserId : GetOrdersQuery, IRequest<IEnumerable<OrderDTO>>
    {
        public Guid UserId { get; set; }

        public GetOrdersQueryWithUserId() { }
        public GetOrdersQueryWithUserId(GetOrdersQuery query, Guid userId)
        {
            UserId = userId;
            StartDate = query.StartDate;
            EndDate = query.EndDate;
            Price = query.Price;
            Price_lt = query.Price_lt;
            Price_ht = query.Price_ht;
            Status = query.Status;
            Offset = query.Offset;
            Limit = query.Limit;
            Sort = query.Sort;
        }

        protected override IQueryable<Order> GetFiltered(IQueryable<Order> collectionToFilter)
            => collectionToFilter
                .FilterIf(o => o.StartDate.Day == StartDate.Value.Day &&
                               o.StartDate.Month == StartDate.Value.Month &&
                               o.StartDate.Year == StartDate.Value.Year, StartDate != null)                
                .FilterIf(o => o.EndDate.Day == EndDate.Value.Day &&
                               o.EndDate.Month == EndDate.Value.Month &&
                               o.EndDate.Year == EndDate.Value.Year, EndDate != null)
                .FilterIf(o => o.Price == Price, Price != null)
                .FilterIf(o => o.Price <= Price_lt, Price_lt != null)
                .FilterIf(o => o.Price >= Price_ht, Price_ht != null)
                .FilterIf(o => o.Status == Status, Status != null);

        protected override IQueryable<Order> GetSorted(IQueryable<Order> collectionToSort)
            => Sort switch
            {
                null => collectionToSort,
                "startDate(asc)" => collectionToSort.Sort(o => o.StartDate, true),
                "startDate(desc)" => collectionToSort.Sort(o => o.StartDate, false),
                "endDate(asc)" => collectionToSort.Sort(o => o.EndDate, true),
                "endDate(desc)" => collectionToSort.Sort(o => o.EndDate, false),
                "orderId(asc)" => collectionToSort.Sort(o => o.Id, true),
                "orderId(desc)" => collectionToSort.Sort(o => o.Id, false),
                "price(asc)" => collectionToSort.Sort(o => o.Price, true),
                "price(desc)" => collectionToSort.Sort(o => o.Price, false),
                _ => throw new ArgumentOutOfRangeException(nameof(Sort))
            };
    }

    public class OrderDTO
    {
        public Guid Id { get; set; }
        public DietDTO[] Diets { get; set; }
        public DeliveryDetailsDTO DeliveryDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public ComplaintDTO[] Complaint { get; set; }

        public OrderDTO() { }
        public OrderDTO(Order order)
        {
            Id = order.Id;
            Diets = order.Diets.Select(d => new DietDTO(d)).ToArray();
            DeliveryDetails = new DeliveryDetailsDTO(order);
            StartDate = order.StartDate;
            EndDate = order.EndDate;
            Price = (int)order.Price;
            Status = order.Status.ToString();
            Complaint = order.Complaints.Select(c => new ComplaintDTO(c)).ToArray();
        }

        public class DietDTO
        {
            public Guid DietId { get; set; }
            public string Name { get; set; }
            public MealDTO[] Meals { get; set; }
            public int Price { get; set; }
            public bool Vegan { get; set; }

            public DietDTO() { }
            public DietDTO(Diet diet)
            {
                DietId = diet.Id;
                Name = diet.Title;
                Meals = diet.Meals.Select(m => new MealDTO(m)).ToArray();
                Price = (int)diet.Price;
                Vegan = diet.IsVegan;
            }
        }
        public class ComplaintDTO
        {
            public Guid ComplaintId { get; set; }
            public Guid OrderId { get; set; }
            public string Description { get; set; }
            public string Answer { get; set; }
            public DateTime Date { get; set; }
            public ComplaintStatus Status { get; set; }

            public ComplaintDTO() { }
            public ComplaintDTO(Complaint complaint)
            {
                ComplaintId = complaint.Id;
                OrderId = complaint.OrderId;
                Description = complaint.Description;
                Answer = complaint.Answer;
                Date = complaint.CreatedDate;
                Status = complaint.Status;
            }
        }
    }

    public class GetOrdersQueryWithUserIdHandler : IRequestHandler<GetOrdersQueryWithUserId, IEnumerable<OrderDTO>>
    {
        private readonly CateringDbContext _dbContext;

        public GetOrdersQueryWithUserIdHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<OrderDTO>> Handle(GetOrdersQueryWithUserId request, CancellationToken cancellationToken)
        {
            if (!_dbContext.Clients.Any(c => c.Id == request.UserId))
                return null;

            var orders = _dbContext.Orders.Where(o => o.ClientId == request.UserId)
                .Include(o => o.Diets)
                .ThenInclude(d => d.Meals)
                .Include(o => o.Client)
                .ThenInclude(c => c.Address)
                .Include(o => o.Complaints);

            var searchResult = await request.GetSearchResult(orders);

            return searchResult.Select(o => new OrderDTO(o)).ToList();
        }
    }
}
