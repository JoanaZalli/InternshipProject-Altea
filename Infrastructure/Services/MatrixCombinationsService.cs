using Application.Contracts;
using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MatrixCombinationsServics :RepositoryBase<MatrixTemplate>, IMatrixCombinationsServices
    {
        public MatrixCombinationsServics(ApplicationDbContext context) : base(context) { }
        public async Task<IEnumerable<MatrixTemplate>> GenerateCombinations(IEnumerable<Lender> lenders, IEnumerable<Product> products, int minTenor, int maxTenor)
        {
            List<MatrixTemplate> combinations = new List<MatrixTemplate>();

            int combinationId = 1;
            foreach (var lender in lenders)
            {
                foreach (var product in products)
                {
                    for (int tenor = minTenor; tenor <= maxTenor; tenor++)
                    {
                        combinations.Add(new MatrixTemplate
                        {
                           //Id = combinationId,
                            Lender = lender,
                            Product = product,
                            Tenor = tenor
                        });
                        combinationId++;
                    }
                }
            }

            return await Task.FromResult(combinations);
        }
    }
}

