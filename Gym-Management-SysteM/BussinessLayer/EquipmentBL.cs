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
    public class EquipmentBL
    {
        private EquipmentDL equipmentDL;
        public EquipmentBL()
        {
            equipmentDL = new EquipmentDL();
        }
        public List<Equipment> GetAllEquipment()
        {
            try
            {
                return equipmentDL.GetAllEquipment();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddEquipment(Equipment equipment)
        {
            try
            {
                return equipmentDL.AddEquipment(equipment);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteEquipment(int id)
        {
            try
            {
                return equipmentDL.DeleteEquipment(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int EditEquipment(Equipment equipment)
        {
            try
            {
                return equipmentDL.EditEquipment(equipment);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
