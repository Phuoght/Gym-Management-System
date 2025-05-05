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
        public int Membership { get; set; }
        public int PT { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
       
        //Contructor load table Members trong DataLayer
        public Member(int id, string name, string gender, DateTime dob, DateTime joinday,
            int membership, int PT, string phone, string status)
        {
            this.ID = id; 
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.JoinDate = joinday;
            this.Membership = membership;
            this.PT = PT;
            this.PhoneNumber = phone;
            this.Status = status;
        }
        //Constructor để thêm Member mới
        public Member(string name,string gender,DateTime dob,DateTime joinday,
            int membership,int PT,string phone,string status) {
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.JoinDate = joinday;
            this.Membership = membership;
            this.PT = PT;
            this.PhoneNumber = phone;
            this.Status = status;
        }
        //Constructor để tìm kiếm Member cho checkin
        public Member(int id, string name, string gender, int membership, int PT,
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
