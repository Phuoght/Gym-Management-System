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
<<<<<<< HEAD
=======
        public string Gender { get; set; }
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
<<<<<<< HEAD
        public Receptionist(int id,string name, DateTime dob, string phoneNumber, string address, string gender, string password, string role)
=======
        public Receptionist(int id,string name, string gender, DateTime dob, string phoneNumber, string address, string password, string role)
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370
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
<<<<<<< HEAD
        public Receptionist(string name, DateTime dob, string phoneNumber, string address, string gender, string password, string role)
=======
        public Receptionist(string name, string gender, DateTime dob, string phoneNumber, string address, string password, string role)
>>>>>>> 0592495a75859ce27d44a5870e0ae5ca274c7370
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
