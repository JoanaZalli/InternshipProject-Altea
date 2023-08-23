using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sorting
{
    public abstract class BaseSorter<TEntity>
    {
        public abstract IEnumerable<TEntity> Sort(IEnumerable<TEntity> entities, string? sortBy, bool? sortAscending);

    }
}
