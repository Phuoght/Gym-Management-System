﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ReceptionistDL : DataProvider
    {
        public List<Receptionist> GetReceptionists()
        {
            string sql = "SELECT * FROM Receptionists";
            int id;

            DateTime dob;
            string name, gender, address, phoneNumber, password, role;
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
                        gender = reader["Receptionist_Gen"].ToString();
                        dob = Convert.ToDateTime(reader["Receptionist_DayOfBirth"]);
                        address = reader["Receptionist_Address"].ToString();
                        phoneNumber = reader["Receptionist_Phone"].ToString();
                        password = reader["Receptionist_Pass"].ToString();
                        role = reader["Role"].ToString();
                        Receptionist receptionist = new Receptionist(id, name, dob, phoneNumber, address, gender, password,  role);
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
                new SqlParameter("@Dob", receptionist.Dob),
                new SqlParameter("@Address", receptionist.Address),
                new SqlParameter("@PhoneNumber", receptionist.PhoneNumber),
                new SqlParameter("@Password", receptionist.Password),
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
                new SqlParameter("@ID", receptionist.ID),
                new SqlParameter("@Name", receptionist.Name),
                new SqlParameter("@Gender", receptionist.Gender),
                new SqlParameter("@Dob", receptionist.Dob),
                new SqlParameter("@Address", receptionist.Address),
                new SqlParameter("@PhoneNumber", receptionist.PhoneNumber),
                new SqlParameter("@Password", receptionist.Password),
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
        public int GetReceptionistID(string name)
        {
            string sql = "usp_FindReceptionistID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@receptionistName", name)
            };
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {
                        return (int)reader["Receptionist_ID"];
                    }
                    else
                    {
                        return -1; // Không tìm thấy
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
