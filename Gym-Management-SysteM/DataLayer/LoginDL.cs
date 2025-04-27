using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using 
namespace DataLayer
{
    class LoginDL:DataProvider
    {
        public bool Login(Rec)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                Connection();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing SQL command: " + ex.Message);
            }
            finally
            {
                Disconnection();
            }
        }
    }
}
