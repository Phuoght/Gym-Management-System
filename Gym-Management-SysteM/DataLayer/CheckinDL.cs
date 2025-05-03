using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public class CheckinDL:DataProvider
    {
        public List<Member> SearchCheckin(string name)
        {
            string memberName, gen, phone, memberShip, Pt, status;
            int id;
            string sql = "usp_SearchCheckin";
            List<Member> members = new List<Member>();
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@name", "%" + name + "%")
            };
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        id = (int)reader["Member_ID"];
                        memberName = reader["Member_Name"].ToString();
                        gen = reader["Member_Gen"].ToString();
                        memberShip = reader["Member_Membership"].ToString();
                        Pt = reader["Member_PT"].ToString();
                        phone = reader["Member_Phone"].ToString();
                        status = reader["Member_Status"].ToString();

                        Member mem = new Member(id, memberName, gen, memberShip, Pt, phone, status);
                        members.Add(mem);
                    }
                }
                return members;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnection();
            }

        }
        public int SaveCheckin(Checkin checkin)
        {
            string sql = "usp_SaveCheckin";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", checkin.MemberID),
                new SqlParameter("@time", checkin.CheckInTime)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters) ;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
