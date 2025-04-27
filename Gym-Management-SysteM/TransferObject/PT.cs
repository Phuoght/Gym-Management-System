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
        public string Dob { get; set; }
        public string Experience { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public PT(string name, string dob, string phoneNumber,string experience, string address, string gender)
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
