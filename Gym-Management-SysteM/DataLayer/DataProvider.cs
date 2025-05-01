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
            string connectionString = "Data Source=.;Initial Catalog=Gym_db;Integrated Security=True";
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
                cnn.Close();
            }
        }

        public object MyExcuteScalar(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = type;
            if (parameters != null) //store
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            try
            {
                Connection();
                return cmd.ExecuteScalar();
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
        public SqlDataReader MyExcuteReader(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = type;
            if (parameters != null) //store
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public int MyExcuteNonQuerry(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = type;
            if (parameters != null) //store
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            try
            {
                Connection();
                return cmd.ExecuteNonQuery();
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
    }
}
