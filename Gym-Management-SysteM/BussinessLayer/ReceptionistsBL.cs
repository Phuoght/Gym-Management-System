using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class ReceptionistsBL
    {
        private ReceptionistsDL receptionistsDL;
        public ReceptionistsBL()
        {
            receptionistsDL = new ReceptionistsDL();
        }
        public List<Receptionist> GetReceptionists()
        {
            try
            {
                return receptionistsDL.GetReceptionists();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi lấy danh sách lễ tân: " + ex.Message);
            }
        }
        public void AddReceptionist(Receptionist receptionist)
        {
            try
            {
                receptionistsDL.Add(receptionist);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thêm lễ tân: " + ex.Message);
            }
        }
        public void DeleteReceptionist(int id)
        {
            try
            {
                receptionistsDL.DeleteReceptionist(id);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi xóa lễ tân: " + ex.Message);
            }
        }
        public void EditReceptionist(Receptionist receptionist)
        {
            try
            {
                receptionistsDL.EditReceptionist(receptionist);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi sửa lễ tân: " + ex.Message);
            }
        }
        public int GetReceptionistID(string name)
        {
            try
            {
                return receptionistsDL.GetReceptionistID(name);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi lấy ID lễ tân: " + ex.Message);
            }
        }
    }
}

