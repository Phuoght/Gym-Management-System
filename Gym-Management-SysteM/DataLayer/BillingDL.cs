using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class BillingDL : DataProvider
    {
       public int AddBilling(Billing billing)
        {
            string sql = "usp_SaveBill";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@receptionist", billing.receptionist),
                new SqlParameter("@member", billing.member),
                new SqlParameter("@date", billing.date),
                new SqlParameter("@cost", billing.cost),
                new SqlParameter("@promotionID", billing.promotionID),
                new SqlParameter("@total", billing.total)
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

