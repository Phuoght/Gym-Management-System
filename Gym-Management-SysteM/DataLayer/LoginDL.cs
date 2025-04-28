using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObject;

namespace DataLayer
{
    class LoginDL:DataProvider
    {
        public bool checkLogin(Receptionist receptionist)
        {
            try
            {
                string sql = "SELECT COUNT(Receptionist_Name) FROM Receptionists WHERE Receptionist_Name = '" + receptionist.Name + "' AND Receptionist_Pass = '" + receptionist.Password + "'";
                return ((int)(MyExcuteScalar(sql, CommandType.Text)) > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
