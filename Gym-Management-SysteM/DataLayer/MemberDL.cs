﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using System.Data;


namespace DataLayer
{
    public class MemberDL : DataProvider
    {
        public List<Member> GetMembers()
        {
            string sql = "SELECT * FROM Members";
            int id, membership, pt;
            string name, gender, phone, status;
            DateTime dob, joinday;
            List<Member> Members = new List<Member>();
            try
            {
                Connection();
                using(SqlDataReader reader = MyExcuteReader(sql,CommandType.Text))
                {
                    while(reader.Read())
                    {
                        id = (int)reader["Member_ID"];
                        name = reader["Member_Name"].ToString();
                        gender = reader["Member_Gen"].ToString();
                        dob = (DateTime)reader["Member_DayOfBirth"];
                        joinday = (DateTime)reader["Member_Date"];
                        membership = (int)reader["Member_Membership"];
                        pt = (int)reader["Member_PT"];
                        phone = reader["Member_Phone"].ToString();
                        status = reader["Member_Status"].ToString();
                        Member member = new Member(id,name,gender,dob,joinday,membership,pt,phone,status);
                        Members.Add(member);
                    }
                }
                return Members;
            }
            catch(SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Disconnection();
            }
        }
        public int AddM(Member member)
        {
            string sql = "usp_AddMember";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", member.Name),
                new SqlParameter("@Gen", member.Gender),
                new SqlParameter("@dob", member.Dob),
                new SqlParameter("@jd", member.JD),
                new SqlParameter("@mbship", member.Membership),
                new SqlParameter("@pt", member.PT),
                new SqlParameter("@phone", member.Phone),
                new SqlParameter("@status", member.Status)
            };

            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);

            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteM(int id)
        {
            string sql = "usp_DeleteMember";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", id)
            };
            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int EditMember(Member member)
        {
            string sql = "usp_UpdateMember";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", member.ID),
                new SqlParameter("@Name", member.Name),
                new SqlParameter("@Gen", member.Gender),
                new SqlParameter("@dob", member.Dob),
                new SqlParameter("@jd", member.JD),
                new SqlParameter("@mbship", member.Membership),
                new SqlParameter("@pt", member.PT),
                new SqlParameter("@phone", member.Phone),
                new SqlParameter("@status", member.Status)
            };

            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int EditMember_Membership(int memberID, int membershipID, DateTime joinDay)
        {
            string sql = "usp_UpdateMember_Membership";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MemberID", memberID),
                new SqlParameter("@newMembershipId", membershipID),
                new SqlParameter("@newJoinDate ", joinDay)
            };
            try
            {
                return MyExcuteNonQuerry(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int GetMemberID(string name,string phone)
        {
            string sql = "usp_FindMemberID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@memberName", name),
                new SqlParameter("@memberPhone", phone)
            };
            try
            {
                Connection();
                using (SqlDataReader reader = MyExcuteReader(sql, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {
                        return (int)reader["Member_ID"];
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
            finally
            {
                Disconnection();
            }
        }
        public int UpdateExpiredMemberships()
        {
            string sql = "usp_UpdateExpiredMemberships";
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
