using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Chetina
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public RushOrder ShippingType { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        //enums
        public enum RushOrder
        {
            Day3Rush,
            Day5Rush,
            Day7Rush,
            Day14NoRush

        }
    }
}
