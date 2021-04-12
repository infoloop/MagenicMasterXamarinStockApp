using System;
using System.Collections.Generic;
using System.Text;

namespace StockWatcherApp.Models
{
    public class StockItem
    {
        public string StockSymbol { get; set; }
        public string CompanyName { get; set; }
        public double Value { get; set; }
        public double Shares { get; set; }
        public double TotalValue 
        {
            get { return Shares * Value; }
        }

    }
}
