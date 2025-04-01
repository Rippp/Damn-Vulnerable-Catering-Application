using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Diets.Queries
{
    public record GetDietDetailsQuery(Guid DietId) : IRequest<GetDietDetailsResultDTO>;

    public class GetDietDetailsResultDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }
        public IEnumerable<GetDietDetailsResultDTOMeal> Meals { get; set; }

        public GetDietDetailsResultDTO(Diet diet)
        {
            Name = diet.Title;
            Price = diet.Price;
            Calories = diet.Calories;
            Vegan = diet.IsVegan;
            Meals = diet.Meals.Select(m => new GetDietDetailsResultDTOMeal(m.Id, m.Name, m.Calories, m.IsVegan));
        }
    }

    public record GetDietDetailsResultDTOMeal(Guid Id, string Name, int Calories, bool IsVegan);

    public class GetDietDetailsQueryHandler : IRequestHandler<GetDietDetailsQuery, GetDietDetailsResultDTO>
    {
        private readonly CateringDbContext _context;

        public GetDietDetailsQueryHandler(CateringDbContext context)
        {
            _context = context;
        }

        public async Task<GetDietDetailsResultDTO> Handle(GetDietDetailsQuery request, CancellationToken cancellationToken)
        {
            var diet = await _context.Diets
                .Include(d => d.Meals)
                .FirstOrDefaultAsync(d => d.Id == request.DietId, cancellationToken);

            return diet == default ? null : new GetDietDetailsResultDTO(diet);
        }
    }
}
