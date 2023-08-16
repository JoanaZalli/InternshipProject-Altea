using Application.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Filtring
{
    public static class BorrowerFiltring
    {
        public static IEnumerable<BorrowerDTO> ApplyFilter(IEnumerable<BorrowerDTO> borrower, string? filterValue)
        {
            
            if (!string.IsNullOrEmpty(filterValue))
            {
                borrower = borrower.Where(b =>
                    b.CompanyName.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    b.VatNumber.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    b.FiscalCode.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    b.DateCreated.ToString("yyyy-MM-dd").Contains(filterValue, StringComparison.OrdinalIgnoreCase)||
                    b.DateUpdated.ToString("yyyy-MM-dd").Contains(filterValue, StringComparison.OrdinalIgnoreCase)

                );
            }

            return borrower;
        }
    }
}
