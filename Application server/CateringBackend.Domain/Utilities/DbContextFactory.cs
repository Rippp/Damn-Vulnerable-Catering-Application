using CateringBackend.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Domain.Utilities
{
    public interface IDbContextFactory
    {
        CateringDbContext GetDbContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        protected readonly DbContextOptions<CateringDbContext> _options;

        public DbContextFactory(DbContextOptions<CateringDbContext> options)
        {
            _options = options;
        }

        public CateringDbContext GetDbContext()
        {
            return new CateringDbContext(_options);
        }
    }
}
