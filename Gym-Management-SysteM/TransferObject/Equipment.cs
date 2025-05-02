using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
        public DateTime lastMaintain { get; set; }
        public DateTime nextMaintain { get; set; }
        public Equipment(string name, string type,int amount, string status, DateTime lastMaintain, DateTime nextMaintain)
        {
            this.name = name;
            this.type = type;
            this.amount = amount;
            this.status = status;
            this.lastMaintain = lastMaintain;
            this.nextMaintain = nextMaintain;
        }
        public Equipment(int id, string name, string type, int amount, string status, DateTime lastMaintain, DateTime nextMaintain)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.amount = amount;
            this.status = status;
            this.lastMaintain = lastMaintain;
            this.nextMaintain = nextMaintain;
        }
    }
}
