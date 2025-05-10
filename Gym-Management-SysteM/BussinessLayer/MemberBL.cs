using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObject;

namespace BusinessLayer
{
    public class MemberBL
    {
        private MemberDL memberDL;
        public MemberBL()
        {
            memberDL = new MemberDL();
        }
        public List<Member> GetMember()
        {
            try
            {
                return memberDL.GetMembers();
            }
            catch (SqlException ex)
            {

                throw new Exception("Lỗi lấy danh sách hội viên: " + ex.Message);
            }
        }

        public void AddMember(Member member)
        {
            try
            {
                memberDL.AddM(member);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thêm hội viên: " + ex.Message);
            }
        }

        public void DeleteMember(int id)
        {
            try
            {
                memberDL.DeleteM(id);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi xóa hội viên: " + ex.Message);
            }
        }
        public void EditMember(Member member)
        {
            try
            {
                memberDL.EditMember(member);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi sửa hội viên: " + ex.Message);
            }
        }

        public void EditMemberMembership(int memberID,int membershipID,DateTime joinDay)
        {
            try
            {
                memberDL.EditMember_Membership(memberID,membershipID,joinDay);
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi sửa hội viên: " + ex.Message);
            }
        }
        public int GetMemberId(string name, string phone)
        {
            try
            {
                return memberDL.GetMemberID(name, phone);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi lấy thông tin hội viên: " + ex.Message);
            }
        }
        public Member GetMemberById(int id)
        {
            return GetMember().FirstOrDefault(m => m.ID == id);
        }
        public int UpdateExpiredMemberships()
        {
            try
            {
                return memberDL.UpdateExpiredMemberships();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
