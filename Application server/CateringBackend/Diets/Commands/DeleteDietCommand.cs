using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Diets.Commands
{
    public record DeleteDietCommand(Guid DietId) : IRequest<(bool dietDeleted, string errorMessage)>;

    public class DeleteDietCommandHandler : IRequestHandler<DeleteDietCommand, (bool dietDeleted, string errorMessage)>
    {
        private readonly CateringDbContext _dbContext;

        public DeleteDietCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(bool dietDeleted, string errorMessage)> Handle(DeleteDietCommand request, CancellationToken cancellationToken)
        {
            var diet = await _dbContext.Diets
                .Where(d => d.IsAvailable)
                .FirstOrDefaultAsync(d => d.Id == request.DietId, cancellationToken);

            if (diet == default)
                return (dietDeleted: false, errorMessage: $"Diet with ID: '{request.DietId}' does not exist");

            diet.MakeUnavailable();
            await _dbContext.SaveChangesAsync(cancellationToken); ;
            return (true, null);
        }
    }
}
