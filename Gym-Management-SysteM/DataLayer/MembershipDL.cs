using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public class MembershipDL : DataProvider
    {
        public List<Membership> GetMemberships()
        {
            string sql = "SELECT * FROM Memberships";
            int id;
            string name,duration, goal,cost;
            List<Membership> Memberships = new List<Membership>();
            try
            {
                Connection();
                using(SqlDataReader reader = MyExcuteReader(sql,CommandType.Text))
                {
                    while(reader.Read())
                    {
                        id = (int)reader["Membership_ID"];
                        name = reader["Membership_Name"].ToString();
                        duration =reader["Membership_Duration"].ToString();
                        goal = reader["Membership_Goal"].ToString();
                        cost = reader["Membership_Cost"].ToString();
                        Membership membership = new Membership(id,name,duration,goal,cost);
                        Memberships.Add(membership);
                    }
                }
                return Memberships;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnection();
            }
        }

        public int AddMbs(Membership membership)
        {
            string sql = "usp_AddMembership";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", membership.Name),
                new SqlParameter("@Duration", membership.Duration),
                new SqlParameter("@Goal", membership.Goal),
                new SqlParameter("@Cost", membership.Cost)
            };
            try
            { 
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            
        }
        public int DeleteMbs(int id) {
            string sql = "usp_DeleteMembership";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", id)
            };
            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int EditMbs(Membership membership)
        {
            string sql = "usp_UpdateMembership";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", membership.ID),
                new SqlParameter("@Name", membership.Name),
                new SqlParameter("@Duration", membership.Duration),
                new SqlParameter("@Goal", membership.Goal),
                new SqlParameter("@Cost", membership.Cost)

            };
            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

    }
}
