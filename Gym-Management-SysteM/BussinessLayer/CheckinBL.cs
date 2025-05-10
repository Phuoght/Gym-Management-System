using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;

namespace BusinessLayer
{
    public class CheckinBL
    {
        private CheckinDL checkinDL;
        public CheckinBL()
        {
            checkinDL = new CheckinDL();
        }
        public List<Member> SearchCheckin(string name)
        {
            try
            {
                return checkinDL.SearchCheckin(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCheckin(Checkin checkin)
        {
            try
            {
                return checkinDL.SaveCheckin(checkin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public (int Duration, DateTime StartDate) GetTimeMemberShip(int id)
        {
            try
            {
                return checkinDL.GetTimeMemberShip(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool IsActiveMembership(DateTime dateNow, DateTime dateMembership)
        {
            try
            {
                return checkinDL.IsActiveMembership(dateNow, dateMembership);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
