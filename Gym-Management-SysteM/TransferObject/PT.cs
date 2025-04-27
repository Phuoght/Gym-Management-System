using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class PT
    {
        public PT(string name, string dob, string phoneNumber,string experience, string address)
        {
            Name = name;
            Dob = dob;
            PhoneNumber = phoneNumber;
            Experience = experience;
            Address = address;
            
        }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Experience { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
