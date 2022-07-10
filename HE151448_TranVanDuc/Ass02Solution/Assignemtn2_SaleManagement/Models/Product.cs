using System;
using System.Collections.Generic;

#nullable disable

namespace Assignemtn2_SaleManagement.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Weight { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
