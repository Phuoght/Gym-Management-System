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
    public class ReceptionistBL
    {
        private ReceptionistDL receptionistDL;
        public ReceptionistBL()
        {
            receptionistDL = new ReceptionistDL();
        }
        public List<Receptionist> GetReceptionists()
        {
            try
            {
                return receptionistDL.GetReceptionists();
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
                receptionistDL.Add(receptionist);
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
                receptionistDL.DeleteReceptionist(id);
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
                receptionistDL.EditReceptionist(receptionist);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi sửa lễ tân: " + ex.Message);
            }
        }
    }
}

