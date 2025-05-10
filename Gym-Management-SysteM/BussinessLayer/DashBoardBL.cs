using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using DataLayer;

namespace BusinessLayer
{
    public class DashBoardBL
    {
        private DashboardDL dashboardDL;
        public DashBoardBL()
        {
            dashboardDL = new DashboardDL();
        }
        public int GetQuantityPTs()
        {
            try
            {
                return dashboardDL.GetQuantityPTs();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityMembers()
        {
            try
            {
                return dashboardDL.GetQuantityMembers();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityReceptionists()
        {
            try
            {
                return dashboardDL.GetQuantityReceptionists();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityMemberShips()
        {
            try
            {
                return dashboardDL.GetQuantityMemberShips();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityEquipments()
        {
            try
            {
                return dashboardDL.GetQuantityEquipments();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityPromotes()
        {
            try
            {
                return dashboardDL.GetQuantityPromotes();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public double GetAllRevenue()
        {
            try
            {
                return dashboardDL.GetAllRevenue();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
