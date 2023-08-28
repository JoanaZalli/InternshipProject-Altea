﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IBorrowerRepository 
    {
        Borrower CreateBorrower(Borrower borrower);
        Task<IEnumerable<Borrower>> GetBorrowersByUserIdAsync(string userId);
         Task<Borrower> GetBorrowerByIdAsync(int id); 

    }
}
