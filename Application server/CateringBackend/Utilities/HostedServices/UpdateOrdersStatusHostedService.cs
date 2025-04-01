using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CateringBackend.Utilities.HostedServices
{
    public class UpdateOrdersStatusHostedService : IHostedService, IDisposable
    {
        private readonly CateringDbContext _dbContext;
        private readonly ILogger<UpdateOrdersStatusHostedService> _logger;
        private Timer _timer;

        public UpdateOrdersStatusHostedService(ILogger<UpdateOrdersStatusHostedService> logger, IServiceScopeFactory factory)
        {
            _logger = logger;
            _dbContext = factory.CreateScope().ServiceProvider.GetRequiredService<CateringDbContext>();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Update Orders Status Hosted Service running.");

            _timer = new Timer(UpdateOrdersStatus, null, TimeSpan.Zero, TimeSpan.FromDays(1));

            return Task.CompletedTask;
        }

        private void UpdateOrdersStatus(object state)
        {
            foreach(var order in _dbContext.Orders)
            {
                if (order.Status == OrderStatus.Paid &&
                   order.StartDate.Date >= DateTime.Today)
                    order.Status = OrderStatus.ToRealized;

                if (order.Status == OrderStatus.Delivered)
                    order.Status = OrderStatus.ToRealized;

                if (order.EndDate.Date < DateTime.Today)
                    order.Status = OrderStatus.Finished;
            }
            _dbContext.SaveChanges();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Update Orders Status Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
