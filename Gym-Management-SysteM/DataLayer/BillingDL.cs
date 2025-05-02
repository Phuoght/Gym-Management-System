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
    public class BillingDL : DataProvider
    {

        public List<Billing> GetBillings()
        {
            string sql = "SELECT * FROM Billings";
            int id, duration, cost;
            string name, goal;
            List<Billing> Billings = new List<Billing>();
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        id = (int)reader["Billing_ID"];
                        name = reader["Billing_Name"].ToString();
                        duration = (int)reader["Billing_Duration"];
                        goal = reader["Billing_Goal"].ToString();
                        cost = (int)reader["Billing_Cost"];
                        Billing billing = new Billing(id, name, duration, goal, cost);
                        Billings.Add(billing);
                    }
                }
                return Billings;
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
        public int Add(Billing billing)
        {
            string sql = "usp_AddBilling";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", billing.Name),
                new SqlParameter("@Duration", billing.Duration),
                new SqlParameter("@Goal", billing.Goal),
                new SqlParameter("@Cost", billing.Cost)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public int DeleteBilling(int id)
        {
            string sql = "usp_DeleteBilling";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", id)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int EditBilling(Billing billing)
        {
            string sql = "usp_UpdateBilling";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", billing.ID),
                new SqlParameter("@Name", billing.Name),
                new SqlParameter("@Duration", billing.Duration),
                new SqlParameter("@Goal", billing.Goal),
                new SqlParameter("@Cost", billing.Cost)

            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

