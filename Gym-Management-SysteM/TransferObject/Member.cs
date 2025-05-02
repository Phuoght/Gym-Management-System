using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TransferObject
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public DateTime JoinDate { get; set; }
        public string Membership { get; set; }
        public string PT { get; set; }
        public string PhoneNumber { get; set; }
        public string Timing { get; set; }
        public string Status { get; set; }
       

        //Contructor dung để load table Members trong DataLayer
        public Member(int id, string name, string gender, DateTime dob, DateTime joinday,
            string membership, string PT, string phone, string timing, string status)
        {
            this.ID = id; 
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.JoinDate = joinday;
            this.Membership = membership;
            this.PT = PT;
            this.PhoneNumber = phone;
            this.Timing = timing;
            this.Status = status;
        }
        //Constructor để thêm Member mới
        public Member(string name,string gender,DateTime dob,DateTime joinday,
            string membership,string PT,string phone,string timing,string status) {
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.JoinDate = joinday;
            this.Membership = membership;
            this.PT = PT;
            this.PhoneNumber = phone;
            this.Timing = timing;
            this.Status = status;
        }
        //Constructor để tìm kiếm Member cho checkin
        public Member(int id, string name, string gender, string membership, string PT,
                        string phone, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Membership = membership;
            this.PT = PT;
            this.PhoneNumber = phone;
            this.Status = status;
        }
    }
}
