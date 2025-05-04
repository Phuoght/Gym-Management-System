using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TransferObject
{
    public class Receptionist
    {
        public int ID {  get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Receptionist(int id, string name, DateTime dob, string phoneNumber, string address, string gender, string password, string role)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Password = password;
            this.Role = role;
        }
        public Receptionist(string name, DateTime dob, string phoneNumber, string address, string gender, string password, string role)
        {
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Password = password;
            this.Role = role;
        }
    }
}
