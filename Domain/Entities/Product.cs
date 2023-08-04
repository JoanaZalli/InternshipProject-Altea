using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Refernce_rate { get; set; }
        public decimal Max_Financed_Amount { get; set; }
        public decimal Min_Financed_Amount { get; set; }
    }
}
