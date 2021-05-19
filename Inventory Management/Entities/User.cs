using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Entities
{
    class User : BaseEntity
    {
        public static string tableName = "users";

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
