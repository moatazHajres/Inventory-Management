using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Entities
{
    class Product : BaseEntity
    {
        public static string tableName = "products";

        public int Id { get; set; }

        public string Name { get; set; }

        public string Barcode { get; set; }

        public double Price { get; set; }
    }
}
