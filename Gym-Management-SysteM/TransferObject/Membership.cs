using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Membership
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Goal { get; set; }
        public string Cost { get; set; }

        //Constructor dung để load table Membership trong DataLayer
        public Membership(int id, string name, string duration, string goal, string cost)
        {
            this.Name = name;
            this.ID = id;
            this.Duration = duration;
            this.Goal = goal;
            this.Cost = cost;

        }
        //Constructor để thêm Membership mới
        public Membership(string name,string duration,string goal,string cost)
        {
            this.Name = name;
            this.Duration = duration;
            this.Goal = goal;
            this.Cost = cost;
        }
    }
}
