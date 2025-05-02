using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer
{
    public class RevenueDL:DataProvider
    {
        public List<Billing> GetBillings(DateTime startDate, DateTime endDate)
        {
            List<Billing> billings = new List<Billing>();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };
            string sql = "usp_ReportRevenue";
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Bill_ID"];
                        int receptionist = (int)reader["Bill_Receptionist"];
                        int member = (int)reader["Bill_Member"];
                        DateTime date = (DateTime)reader["Bill_Date"];
                        double cost = Convert.ToSingle(reader["Bill_Cost"]);
                        string promotionID = reader["Bill_PromotionID"].ToString();
                        double total = Convert.ToSingle(reader["Bill_Total"]);
                        Billing billing = new Billing(id, receptionist, member, date, cost, promotionID, total);
                        billings.Add(billing);
                    }
                }
                return billings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnection();
            }
        }
    }
}
