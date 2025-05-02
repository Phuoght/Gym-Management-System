using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ReceptionistsDL : DataProvider
    {
        public List<Receptionist> GetReceptionists()
        {
            string sql = "SELECT * FROM Receptionists";
            int id;
            string name, gender, address, phoneNumber, password, dob, experience, role;
            List<Receptionist> Receptionists = new List<Receptionist>();
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        id = (int)reader["Receptionist_ID"];
                        name = reader["Receptionist_Name"].ToString();
                        gender = reader["Receptionist_Gender"].ToString();
                        address = reader["Receptionist_Address"].ToString();
                        phoneNumber = reader["Receptionist_PhoneNumber"].ToString();
                        password = reader["Receptionist_Password"].ToString();
                        dob = reader["Receptionist_Dob"].ToString();
                        experience = reader["Receptionist_Experience"].ToString();
                        role = reader["Receptionist_Role"].ToString();
                        Receptionist receptionist = new Receptionist(id, name, gender, address, phoneNumber, password, dob, experience, role);
                        Receptionists.Add(receptionist);
                    }
                }
                return Receptionists;
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
        public int Add(Receptionist receptionist)
        {
            string sql = "usp_AddReceptionist";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", receptionist.Name),
                new SqlParameter("@Gender", receptionist.Gender),
                new SqlParameter("@Address", receptionist.Address),
                new SqlParameter("@PhoneNumber", receptionist.PhoneNumber),
                new SqlParameter("@Password", receptionist.Password),
                new SqlParameter("@Dob", receptionist.Dob),
                new SqlParameter("@Experience", receptionist.Experience),
                new SqlParameter("@Role", receptionist.Role)
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
        public int DeleteReceptionist(int id)
        {
            string sql = "usp_DeleteReceptionist";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", id)
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
        public int EditReceptionist(Receptionist receptionist)
        {
            string sql = "usp_UpdateReceptionist";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", receptionist.Name),
                new SqlParameter("@Gender", receptionist.Gender),
                new SqlParameter("@Address", receptionist.Address),
                new SqlParameter("@PhoneNumber", receptionist.PhoneNumber),
                new SqlParameter("@Password", receptionist.Password),
                new SqlParameter("@Dob", receptionist.Dob),
                new SqlParameter("@Experience", receptionist.Experience),
                new SqlParameter("@Role", receptionist.Role)

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
