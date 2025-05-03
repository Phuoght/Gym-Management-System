using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Billing
    {
        public int id { get; set; }
        public int receptionist { get; set; }
        public int member { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }
        public string promotionID { get; set; }
        public double total { get; set; }

        public Billing(int id, int receptionist, int member, DateTime date, double cost, string promotionID, double total)
        {
            this.id = id;
            this.receptionist = receptionist;
            this.member = member;
            this.date = date;
            this.cost = cost;
            this.promotionID = promotionID;
            this.total = total;
        }
        public Billing(int receptionist, int member, DateTime date, double cost, string promotionID, double total)
        {
            this.receptionist = receptionist;
            this.member = member;
            this.date = date;
            this.cost = cost;
            this.promotionID = promotionID;
            this.total = total;
        }
    }

}

