using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Diets.Commands
{
    public class AddDietCommand : IRequest<(bool dietAdded, string errorMessage)>
    {
        public string Name { get; set; }
        public Guid[] MealIds { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class AddDietCommandHandler : IRequestHandler<AddDietCommand, (bool dietAdded, string errorMessage)>
    {
        private readonly CateringDbContext _dbContext;

        public AddDietCommandHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(bool dietAdded, string errorMessage)> Handle(AddDietCommand request, CancellationToken cancellationToken)
        {
            if(await DietWithGivenNameIsAvailable(request.Name))
                return (false, $"Diet with name ({request.Name}) is already available");

            var meals = await _dbContext.Meals
                .Where(m => m.IsAvailable && request.MealIds.Contains(m.Id))
                .ToListAsync(cancellationToken);

            if (meals.Count != request.MealIds.Length)
            {
                return (false, GetMealsNotExistsErrorMessage(request, meals));
            }

            await AddDietToDatabaseAsync(request, meals, cancellationToken);
            return (true, null);
        }

        private async Task<bool> DietWithGivenNameIsAvailable(string name) => 
            await _dbContext.Diets.FirstOrDefaultAsync(diet => diet.Title == name && diet.IsAvailable) != default;

        private static string GetMealsNotExistsErrorMessage(AddDietCommand request, List<Meal> meals)
        {
            var notExistingMealIds = request.MealIds.Where(id => meals.TrueForAll(m => m.Id != id)).ToList();
            return $"Meals of IDs: ({string.Join(", ", notExistingMealIds)}) do not exist or are unavailable";
        }

        private async Task AddDietToDatabaseAsync(AddDietCommand addDietCommand, List<Meal> meals, CancellationToken cancellationToken)
        {
            var dietToAdd = Diet.Create(
                title: addDietCommand.Name,
                description: addDietCommand.Description,
                addDietCommand.Price,
                meals
            );
            await _dbContext.Diets.AddAsync(dietToAdd, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
