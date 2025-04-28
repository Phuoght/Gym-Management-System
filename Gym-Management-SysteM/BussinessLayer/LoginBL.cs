using DataLayer;
using TransferObject;
using System.Data.SqlClient;
namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;
        public LoginBL()
        {
            loginDL = new LoginDL();
        }
        public bool checkLogin(Receptionist receptionist)
        {
            try
            {
                return loginDL.checkLogin(receptionist);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
