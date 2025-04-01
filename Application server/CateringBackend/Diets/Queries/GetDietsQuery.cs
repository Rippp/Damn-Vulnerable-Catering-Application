using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using CateringBackend.Search;
using CateringBackend.Utilities.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Diets.Queries
{
    public class GetDietsQuery : BaseSearchQuery<Diet>, IRequest<IEnumerable<DietsSearchResultDTO>>
    {
        public string Name { get; set; }
        public string Name_with { get; set; }
        public bool? Vegan { get; set; }
        public int? Calories { get; set; }
        public int? Calories_lt { get; set; }
        public int? Calories_ht { get; set; }
        public decimal? Price { get; set; }
        public decimal? Price_lt { get; set; }
        public decimal? Price_ht { get; set; }

        protected override IQueryable<Diet> GetFiltered(IQueryable<Diet> collectionToFilter)
            => collectionToFilter
                .FilterIf(d => d.Title == Name, !string.IsNullOrWhiteSpace(Name))
                .FilterIf(d => d.Title.Contains(Name_with), !string.IsNullOrWhiteSpace(Name_with))
                .FilterIf(d => d.Meals.All(m => m.IsVegan) == Vegan, Vegan.HasValue)
                .FilterIf(d => d.Meals.Sum(m => m.Calories) == Calories, Calories != null)
                .FilterIf(d => d.Meals.Sum(m => m.Calories) > Calories_ht, Calories_ht != null)
                .FilterIf(d => d.Meals.Sum(m => m.Calories) < Calories_lt, Calories_lt != null)
                .FilterIf(d => d.Price == Price, Price != null)
                .FilterIf(d => d.Price >= Price_ht, Price_ht != null)
                .FilterIf(d => d.Price <= Price_lt, Price_lt != null);

        protected override IQueryable<Diet> GetSorted(IQueryable<Diet> collectionToSort)
            => Sort switch
            {
                null => collectionToSort,
                "title(asc)" => collectionToSort.Sort(d => d.Title, true),
                "title(desc)" => collectionToSort.Sort(d => d.Title, false),
                "calories(asc)" => collectionToSort.Sort(d => d.Meals.Sum(m => m.Calories), true),
                "calories(desc)" => collectionToSort.Sort(d => d.Meals.Sum(m => m.Calories), false),
                "price(asc)" => collectionToSort.Sort(d => d.Price, true),
                "price(desc)" => collectionToSort.Sort(d => d.Price, false),
                _ => throw new ArgumentOutOfRangeException(nameof(Sort))
            };
    }

    public class GetDietsQueryHandler : IRequestHandler<GetDietsQuery, IEnumerable<DietsSearchResultDTO>>
    {
        private readonly CateringDbContext _context;

        public GetDietsQueryHandler(CateringDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DietsSearchResultDTO>> Handle(GetDietsQuery request,
            CancellationToken cancellationToken)
        {
            var availableDietsWithMeals = 
                _context.Diets
                    .Where(d => d.IsAvailable)
                    .Include(d => d.Meals);

            var searchResult = await request.GetSearchResult(availableDietsWithMeals);

            return searchResult
                .Select(d => new DietsSearchResultDTO(d))
                .ToList();
        }
    }
}
