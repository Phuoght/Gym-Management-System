using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class RevenueBL
    {
        private RevenueDL revenueDL;
        public RevenueBL()
        {
            revenueDL = new RevenueDL();
        }
        public List<Billing> GetBillings(DateTime startDate, DateTime endDate)
        {
            try
            {
                return revenueDL.GetBillings(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
