using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Search
{
    public abstract class BaseSearchQuery<T>
    {
        public int Offset { get; set; } = SearchConstants.DefaultOffset;
        public int Limit { get; set; } = SearchConstants.DefaultLimit;
        public string Sort { get; set; }

        public async Task<IEnumerable<T>> GetSearchResult(IQueryable<T> collectionToApplySearch)
            => await GetPaginated(GetSorted(GetFiltered(collectionToApplySearch))).ToListAsync();
            
        protected abstract IQueryable<T> GetFiltered(IQueryable<T> collectionToFilter);

        protected abstract IQueryable<T> GetSorted(IQueryable<T> collectionToSort);

        private IQueryable<T> GetPaginated(IQueryable<T> collectionToPaginate) =>
            collectionToPaginate.Skip(Offset).Take(Limit);
    }

}
