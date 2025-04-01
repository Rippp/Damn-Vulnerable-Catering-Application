using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Meals.Commands
{
    public record DeleteMealCommand(Guid MealId) : IRequest<Meal>;

    public class DeleteMealCommandHandler : IRequestHandler<DeleteMealCommand, Meal>
    {
        private readonly CateringDbContext _dbContext;

        public DeleteMealCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Meal> Handle(DeleteMealCommand request, CancellationToken cancellationToken)
        {
            var meal = await _dbContext.Meals
                .Where(meal => meal.IsAvailable)
                .FirstOrDefaultAsync(meal => meal.Id == request.MealId, cancellationToken);

            if (meal == default)
                return null;

            if (await MealWithGivenIdIsContainedByAvailableDiet(request.MealId))
                return meal;

            meal.MakeUnavailable();
            await _dbContext.SaveChangesAsync(cancellationToken);
            return meal;
        }

        private async Task<bool> MealWithGivenIdIsContainedByAvailableDiet(Guid mealId) =>
            await _dbContext.Diets.AnyAsync(diet => diet.IsAvailable && diet.Meals.Any(meal => meal.Id == mealId));
    }
}
