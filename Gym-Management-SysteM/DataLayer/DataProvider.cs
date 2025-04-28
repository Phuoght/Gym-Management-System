using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace DataLayer
{
    public class DataProvider
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public DataProvider()
        {
            string connectionString = "Data Source=.;Initial Catalog=Gym_db;Integrated Security=True;Trust Server Certificate=True";
            cnn = new SqlConnection(connectionString);
        }

        public void Connection()
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        public void Disconnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public object MyExcuteScalar(string sql, CommandType type)
        {
            try
            {
                Connection();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thực thi câu lệnh SQL: " + ex.Message);
            }
            finally
            {
                Disconnection();
            }
        }
        public SqlDataReader MyExcuteReader(string sql, CommandType type)
        {
            try
            {
                Connection();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thực thi câu lệnh SQL: " + ex.Message);
            }
            finally
            {
                Disconnection();
            }
        }
    }
}
