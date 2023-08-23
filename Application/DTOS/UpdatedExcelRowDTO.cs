using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class UpdatedExcelRowDTO
    {
        public string LenderName { get; set; }
        public string ProductName { get; set; }
        public int Tenor { get; set; }
        public double Spread { get; set; }
    }
}
