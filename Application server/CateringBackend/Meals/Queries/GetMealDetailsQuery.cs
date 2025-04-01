using System;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Meals.Queries
{
    public record GetMealDetailsQuery(Guid MealId) : IRequest<MealDTO>;

    public class GetMealDetailsQueryHandler : IRequestHandler<GetMealDetailsQuery, MealDTO>
    {
        private readonly CateringDbContext _dbContext;

        public GetMealDetailsQueryHandler(CateringDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MealDTO> Handle(GetMealDetailsQuery request, CancellationToken cancellationToken)
        {
            var meal = await _dbContext.Meals.FirstOrDefaultAsync(meal => meal.Id == request.MealId, cancellationToken);
            
            if(meal == default)
            {
                return null;
            }

            return new MealDTO(meal);
        }
    }
}
