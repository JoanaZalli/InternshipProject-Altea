﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface ICompanyTypeRepository
    {
        Task<IEnumerable<CompanyType>> GetAllCompanyTypesAsync(bool trackChanges);

    }
}
