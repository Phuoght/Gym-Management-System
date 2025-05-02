using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class PromotionBL
    {
        private PromotionDL promotionDL;
        public PromotionBL()
        {
            promotionDL = new PromotionDL();
        }
        public List<Promotion> GetAllPromotions()
        {
            try
            {
                return promotionDL.GetAllPromotions();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public int AddPromotion(Promotion promotion)
        {
            try
            {
                return promotionDL.AddPromotion(promotion);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public int DeletePromotion(string code)
        {
            try
            {
                return promotionDL.DeletePromotion(code);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public int EditPromotion(Promotion promotion)
        {
            try
            {
                return promotionDL.EditPromotion(promotion);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
