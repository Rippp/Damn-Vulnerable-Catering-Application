using System;
using System.Linq;
using System.Linq.Expressions;

namespace CateringBackend.Utilities.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> FilterIf<T>(
            this IQueryable<T> collectionToFilter,
            Expression<Func<T, bool>> filteringFunction,
            bool shouldFilter) 
            => shouldFilter ? collectionToFilter.Where(filteringFunction) : collectionToFilter;

        public static IOrderedQueryable<T> Sort<T, TKey>(
            this IQueryable<T> collectionToSort,
            Expression<Func<T, TKey>> sortSelector,
            bool ascending
        ) => ascending ? collectionToSort.OrderBy(sortSelector) : collectionToSort.OrderByDescending(sortSelector);
    }
}
