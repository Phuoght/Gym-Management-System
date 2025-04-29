using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class ptBL
    {
        private ptDL ptDL;
        public ptBL()
        {
            ptDL = new ptDL();
        }
        public List<PT> GetPTs()
        {
            try
            {
                return ptDL.GetPTs();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi lấy danh sách PTs: " + ex.Message);
            }
        }

        public void AddPT(PT pt)
        {
            try
            {
                ptDL.Add(pt);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thêm PT: " + ex.Message);
            }
        }
    }
}
