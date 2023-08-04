using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sorting
{
    
        public class BorrowerSorter : BaseSorter<Borrower>
        {
            public override IEnumerable<Borrower> Sort(IEnumerable<Borrower> borrowers, string? sortBy, bool? sortAscending)
            {
                if (!string.IsNullOrEmpty(sortBy) && sortAscending.HasValue)
                {
                    switch (sortBy.ToLower())
                    {
                        case "datecreated":
                            return sortAscending.Value
                                ? borrowers.OrderBy(b => b.DateCreated)
                                : borrowers.OrderByDescending(b => b.DateCreated);
                        case "companyname":
                            return sortAscending.Value
                                ? borrowers.OrderBy(b => b.CompanyName)
                                : borrowers.OrderByDescending(b => b.CompanyName);
                        default:
                            return borrowers;
                    }
                }

                return borrowers;
            }
        }

    

}
