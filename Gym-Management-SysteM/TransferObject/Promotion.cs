using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Promotion
    {
        public string code { get; set; }
        public string describe { get; set; }
        public int discount { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Promotion(string code, int discount, string describe, DateTime startDate, DateTime endDate)
        {
            this.code = code;
            this.discount = discount;
            this.describe = describe;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
