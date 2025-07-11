﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ptDL : DataProvider
    {
        public List<PT> GetPTs()
        {
            string sql = "SELECT * FROM PTs";
            int id;
            string name, gender, phone, experience, address;
            DateTime dob;
            List<PT> PTs = new List<PT>();
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        id = (int)reader["PT_ID"];
                        name = reader["PT_Name"].ToString();
                        gender = reader["PT_Gen"].ToString();
                        dob = (DateTime)reader["PT_DayOfBirth"];
                        phone = reader["PT_Phone"].ToString();
                        experience = reader["PT_Experience"].ToString();
                        address = reader["PT_Address"].ToString();

                        PT pt = new PT(id, name, gender, dob, phone, experience, address);
                        PTs.Add(pt);
                    }
                }
                return PTs;
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

        public int Add(PT pt)
        {
            string sql = "usp_AddPT";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", pt.Name),
                new SqlParameter("@Gender", pt.Gender),
                new SqlParameter("@Dob", pt.Dob),
                new SqlParameter("@Phone", pt.PhoneNumber),
                new SqlParameter("@Experience", pt.Experience),
                new SqlParameter("@Address", pt.Address)
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
        public int DeletePT(int id)
        {
            string sql = "usp_DelPT"; 
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
        public int EditPT(PT pt)
        {
            string sql = "usp_UpdatePT";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", pt.ID),
                new SqlParameter("@Name", pt.Name),
                new SqlParameter("@Gender", pt.Gender),
                new SqlParameter("@Dob", pt.Dob),
                new SqlParameter("@Phone", pt.PhoneNumber),
                new SqlParameter("@Experience", pt.Experience),
                new SqlParameter("@Address", pt.Address)
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
