﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetProductAsync();
        Task<Product> GetProductByNameAsync(string productName);

    }
}
