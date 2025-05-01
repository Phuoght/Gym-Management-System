using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
namespace DataLayer
{
    class MemberDL : DataProvider
    {
        public List<MemberAccessException> GetMembers()
        {
            string sql = "SELECT * FROM Members";
            int id, pt, membership;
            string name, gender, phone, timing, status;
            DateTime dob, joinday;
            List<Member> Members = new List<Member>();

        }
    }
}
