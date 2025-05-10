using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class DashboardDL : DataProvider
    {
        public int GetQuantityPTs()
        {
            string sql = "SELECT COUNT(*) FROM PTs";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityMembers()
        {
            string sql = "SELECT COUNT(*) FROM Members";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityReceptionists()
        {
            string sql = "SELECT COUNT(*) FROM Receptionists";
            try
            {
                return ((int)MyExcuteScalar(sql, CommandType.Text) - 1);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityMemberShips()
        {
            string sql = "SELECT COUNT(*) FROM MemberShips";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityEquipments()
        {
            string sql = "SELECT COUNT(*) FROM Equipments";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetQuantityPromotes()
        {
            string sql = "SELECT COUNT(*) FROM Promotions";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public double GetAllRevenue()
        {
            string sql = "SELECT SUM(Bill_Total) FROM Bills";
            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                return result != DBNull.Value ? Convert.ToDouble(result) : 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
