using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;

namespace DataLayer
{
    public class PromotionDL : DataProvider
    {

        public List<Promotion> GetAllPromotions()
        {
            List<Promotion> promotions = new List<Promotion>();
            string code, describe;
            int discount;
            DateTime startDate, endDate;
            string sql = "SELECT * FROM Promotions";
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        code = reader["Promotion_ID"].ToString();
                        discount = (int)reader["Promotion_Discount"];
                        describe = reader["Promotion_Describe"].ToString();
                        startDate = (DateTime)(reader["Promotion_StartDate"]);
                        endDate = (DateTime)(reader["Promotion_EndDate"]);

                        Promotion promotion = new Promotion(code, discount, describe, startDate, endDate);
                        promotions.Add(promotion);
                    }
                }
                return promotions;
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
        public int AddPromotion(Promotion promotion)
        {
            string sql = "usp_AddPromotion";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@code", promotion.code),
                new SqlParameter("@describe", promotion.describe),
                new SqlParameter("@discount", promotion.discount),
                new SqlParameter("@startDate", promotion.startDate),
                new SqlParameter("@endDate", promotion.endDate)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeletePromotion(string code)
        {
            string sql = "usp_DelPromotion";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@code", code)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int EditPromotion(Promotion promotion)
        {
            string sql = "usp_EditPromotion";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@code", promotion.code),
                new SqlParameter("@describe", promotion.describe),
                new SqlParameter("@discount", promotion.discount),
                new SqlParameter("@startDate", promotion.startDate),
                new SqlParameter("@endDate", promotion.endDate)
            };
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDiscountStartEnd(string promotionID)
        {
            string sql = "usp_GetDiscount";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@code", promotionID),
            };
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    List<string> discountStartEnd = new List<string>();
                    if (reader.Read())
                    {
                        discountStartEnd.Add(reader["Promotion_Discount"].ToString());
                        discountStartEnd.Add(reader["Promotion_StartDate"].ToString());
                        discountStartEnd.Add(reader["Promotion_EndDate"].ToString());
                    }
                    return discountStartEnd;
                }
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
        public bool GetActivePromotions(DateTime nowDate, DateTime startDate, DateTime endDate)
        {
            string sql = "usp_GetActivePromotions";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@nowDate", nowDate),
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };
            try
            {
                int result = Convert.ToInt32(MyExcuteScalar(sql, CommandType.StoredProcedure, parameters));
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
