using System;
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
            string sql = "SELECT PT_Name,PT_Gen,PT_DayOfBirth,PT_Phone,PT_Experience,PT_Address FROM PTs";
            string name, gender, dob, phone, experience, address;
            List<PT> PTs = new List<PT>();
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        name = reader["PT_Name"].ToString();
                        gender = reader["PT_Gen"].ToString();
                        dob = reader["PT_DayOfBirth"].ToString();
                        phone = reader["PT_Phone"].ToString();
                        experience = reader["PT_Experience"].ToString();
                        address = reader["PT_Address"].ToString();

                        PT pt = new PT(name, gender, dob, phone, experience, address);
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
            string sql = "INSERT INTO PTs(PT_Name, PT_Gen, PT_DayOfBirth, PT_Phone, PT_Experience, PT_Address) VALUES" +
                " ( '" + pt.Name + "',  '" + pt.Gender + "','" + pt.Dob + "', '" + pt.PhoneNumber + "', '" + pt.Experience + "', '" + pt.Address + "')";
            try
            {
                return MyExcuteNonQuerry(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
