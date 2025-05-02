using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class BillingBL
    {
        private BillingDL billingDL;
        public BillingBL()
        {
            billingDL = new BillingDL();
        }
        public List<Billing> GetBillings()
        {
            try
            {
                return billingDL.GetBillings();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi lấy danh sách thanh toán: " + ex.Message);
            }
        }
        public void AddBilling(Billing billing)
        {
            try
            {
                billingDL.Add(billing);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thêm thanh toán: " + ex.Message);
            }
        }
        public void DeleteBilling(int id)
        {
            try
            {
                billingDL.DeleteBilling(id);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi xóa thanh toán: " + ex.Message);
            }
        }
        public void EditBilling(Billing billing)
        {
            try
            {
                billingDL.EditBilling(billing);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi sửa thanh toán: " + ex.Message);
            }
        }
    }
}

