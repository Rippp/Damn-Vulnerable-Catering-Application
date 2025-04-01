using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Users.Client.Commands
{
    public class PayForOrderCommand : IRequest<(bool, bool)>
    {
        public Guid ClientId { get; set; }
        public Guid OrderId { get; set; }
    }

    public class PayForOrderCommandHandler : IRequestHandler<PayForOrderCommand, (bool orderExists, bool paidForOrder)>
    {
        private readonly CateringDbContext _dbContext;

        public PayForOrderCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(bool orderExists, bool paidForOrder)> Handle(PayForOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .Where(o => o.Status == Domain.Entities.Enums.OrderStatus.WaitingForPayment)
                .FirstOrDefaultAsync(o => o.Id == request.OrderId);

            if (order == default)
                return (orderExists: false, paidForOrder: false);

            if (order.ClientId != request.ClientId)
                return (orderExists: true, paidForOrder: false);

            order.Status = Domain.Entities.Enums.OrderStatus.Paid;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return (orderExists: true, paidForOrder: true);
        }
    }
}