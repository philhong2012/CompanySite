using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Utility
{
    public static class IQueryableExtension
    {
        public static IQueryable<T> Page<T, TResult>(this IQueryable<T> query,
                        int pageNum, int pageSize,
                        Expression<Func<T, TResult>> orderByProperty,
                        bool isAscendingOrder, out int rowsCount)
        {
            if (pageSize <= 0) pageSize = 20;

            rowsCount = query.Count();

            if (rowsCount <= pageSize || pageNum <= 0) pageNum = 1;

            int excludedRows = (pageNum - 1) * pageSize;

            if (isAscendingOrder)
                query = query.OrderBy(orderByProperty);
            else
                query = query.OrderByDescending(orderByProperty);

            return query.Skip(excludedRows).Take(pageSize);
        }
    }
}
