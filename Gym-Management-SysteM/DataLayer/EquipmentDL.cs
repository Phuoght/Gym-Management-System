using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class EquipmentDL:DataProvider
    {
        public List<Equipment> GetAllEquipment()
        {
            List<Equipment> equipments = new List<Equipment>();
            int id, amount;
            string name, type, status;
            DateTime lastMaintain, nextMaintain;
            string sql = "SELECT * FROM Equipments";
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        id = (int)reader["Equipment_ID"];
                        name = reader["Equipment_Name"].ToString();
                        type = reader["Equipment_Type"].ToString();
                        amount = (int)reader["Equipment_Amount"];
                        status = reader["Equipment_Status"].ToString();
                        lastMaintain = (DateTime)reader["Equipment_LastMaintain"];
                        nextMaintain = (DateTime)reader["Equipment_NextMaintain"];

                        Equipment equipment = new Equipment(id, name, type, amount, status, lastMaintain, nextMaintain);
                        equipments.Add(equipment);
                    }
                }
                return equipments;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnection();
            }
        }
        public int AddEquipment(Equipment equipment)
        {
            string sql = "usp_AddEquipment";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@name", equipment.name),
                new SqlParameter("@type", equipment.type),
                new SqlParameter("@amount", equipment.amount),
                new SqlParameter("@status", equipment.status),
                new SqlParameter("@lastMaintain", equipment.lastMaintain),
                new SqlParameter("@nextMaintain", equipment.nextMaintain)
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
        public int DeleteEquipment(int id)
        {
            string sql = "usp_DelEquipment";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", id)
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
        public int EditEquipment(Equipment equipment)
        { 
            string sql = "usp_EditEquipment";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", equipment.id),
                new SqlParameter("@name", equipment.name),
                new SqlParameter("@type", equipment.type),
                new SqlParameter("@amount", equipment.amount),
                new SqlParameter("@status", equipment.status),
                new SqlParameter("@lastMaintain", equipment.lastMaintain),
                new SqlParameter("@nextMaintain", equipment.nextMaintain)
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
