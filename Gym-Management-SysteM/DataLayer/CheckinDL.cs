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
            string memberName, gen, phone, status;
            int id, memberShip, Pt;
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
                        memberShip = (int)reader["Member_Membership"];
                        Pt = (int)reader["Member_PT"];
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
        public (int Duration, DateTime StartDate) GetTimeMemberShip(int id)
        {
            string sql = "usp_GetTimeMembership";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id),
            };
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {
                        return ((int)reader["MemberShip_Duration"], (DateTime)reader["Member_Date"]);
                    }
                    else
                    {
                        return (-1, DateTime.MinValue);
                    }
                }
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
        public bool IsActiveMembership(DateTime dateNow, DateTime dateMembership)
        {
            string sql = "usp_IsActiveMembership";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@dateNow", dateNow),
                new SqlParameter("@dateMembership", dateMembership)
            };
            try
            {
                int result = (int)MyExcuteScalar(sql, CommandType.StoredProcedure, parameters);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
