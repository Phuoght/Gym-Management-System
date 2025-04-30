using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class PT
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public DateTime Dob { get; set; }
        public string Experience { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        // Constructor dùng để load table PTs trong DataLayer
        public PT(int id, string name, string gender, DateTime dob, string phoneNumber, string experience, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.Experience = experience;
            this.Address = address;
            this.Gender = gender;
        }
        // Constructor dùng để thêm PT mới
        public PT(string name, string gender, DateTime dob, string phoneNumber, string experience, string address)
        {
            this.Name = name;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.Experience = experience;
            this.Address = address;
            this.Gender = gender;
        }
    }
}
