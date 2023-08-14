using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IApplicationRepository
    {
        Applicationn CreateApplication(Applicationn application);
        Task<Applicationn> GetApplicationByIdAsync(int id);

        Task<bool> ChangeProductAsync(Applicationn application, int productId);
        Task<IEnumerable<Applicationn>> GetApplicationsOfABorrowerById(int borrowerId);
    }
}
