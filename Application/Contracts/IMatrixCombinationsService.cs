using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IMatrixCombinationsServices
    {
        Task<IEnumerable<MatrixTemplate>> GenerateCombinations(IEnumerable<Lender> lenders, IEnumerable<Product> products, int minTenor, int maxTenor);

    }
}
