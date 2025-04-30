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
        public int Duration { get; set; }
        public string Goal { get; set; }
        public int Cost { get; set; }

        //Constructor dung để load table Membership trong DataLayer
        public Membership(int id, string name, int duration, string goal, int cost)
        {
            this.Name = name;
            this.ID = id;
            this.Duration = duration;
            this.Goal = goal;
            this.Cost = cost;

        }
        //Constructor để thêm Membership mới
        public Membership(string name,int duration,string goal,int cost)
        {
            this.Name = name;
            this.Duration = duration;
            this.Goal = goal;
            this.Cost = cost;
        }
    }
}
