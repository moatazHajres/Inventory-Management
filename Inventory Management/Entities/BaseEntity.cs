using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Entities
{
    class BaseEntity
    {
        public static string tableName;

        public int Id { get; set; }
    }
}
