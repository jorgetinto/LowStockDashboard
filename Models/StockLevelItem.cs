using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LowStockDashboard.Models
{
    public class StockLevelItem
    {
        public string SKU { get; set; }

        public string ProductTitle { get; set; }

        public int OnOrder { get; set; }

        public int Due { get; set; }

        public int StockLevel { get; set; }

        public string Location { get; set; }
    }
}