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
        public int AddBilling(Billing billing)
        {
            try
            {
                return billingDL.AddBilling(billing);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

