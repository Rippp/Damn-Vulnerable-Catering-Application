using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Search;
using CateringBackend.Utilities.Extensions;
using MediatR;

namespace CateringBackend.Meals.Queries
{
    public class GetMealsQuery : BaseSearchQuery<Meal>, IRequest<IEnumerable<MealSearchResultDTO>>
    {
        public string Name { get; set; }
        public string Name_with { get; set; }
        public bool? Vegan { get; set; }
        public int? Calories { get; set; }
        public int? Calories_lt { get; set; }
        public int? Calories_ht { get; set; }

        protected override IQueryable<Meal> GetFiltered(IQueryable<Meal> collectionToFilter)
            => collectionToFilter
                .FilterIf(m => m.Name == Name, !string.IsNullOrWhiteSpace(Name))
                .FilterIf(m => m.Name.Contains(Name_with), !string.IsNullOrWhiteSpace(Name_with))
                .FilterIf(m => m.IsVegan == Vegan, Vegan.HasValue)
                .FilterIf(m => m.Calories == Calories, Calories != null)
                .FilterIf(m => m.Calories > Calories_ht, Calories_ht != null)
                .FilterIf(m => m.Calories < Calories_lt, Calories_lt != null);

        protected override IQueryable<Meal> GetSorted(IQueryable<Meal> collectionToSort)
            => Sort switch
            {
                null => collectionToSort,
                "title(asc)" => collectionToSort.Sort(m => m.Name, true),
                "title(desc)" => collectionToSort.Sort(m => m.Name, false),
                "calories(asc)" => collectionToSort.Sort(m => m.Calories, true),
                "calories(desc)" => collectionToSort.Sort(m => m.Calories, false),
                _ => throw new ArgumentOutOfRangeException(nameof(Sort))
            };
    }

    public class GetMealsQueryHandler : IRequestHandler<GetMealsQuery, IEnumerable<MealSearchResultDTO>>
    {
        private readonly CateringDbContext _context;

        public GetMealsQueryHandler(CateringDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MealSearchResultDTO>> Handle(GetMealsQuery request,
            CancellationToken cancellationToken)
        {
            var availableMeals = _context.Meals.Where(m => m.IsAvailable);

            var searchResult = await request.GetSearchResult(availableMeals);

            return searchResult
                .Select(m => new MealSearchResultDTO(m))
                .ToList();
        }
    }
}
