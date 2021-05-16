using Inventory_Management.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Entities
{
    class Stock : BaseEntity
    {
        public static string tableName = "stock";

        public int Id { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }

        /*private StockAdjustmentAction _action;

        public string Action
        {
            get { return _action.ToString(); }
            set { _action = (StockAdjustmentAction)Enum.Parse(typeof(StockAdjustmentAction), value); }
        }*/


    }
}
