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
            catch(SqlException ex)
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
            catch(SqlException ex)
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
            catch(SqlException ex)
            {
                throw new Exception("Lỗi xóa hội viên: " + ex.Message);
            }
        }
        public void EditMember(Member member)
        {
            try
            {
                memberDL.EditM(member);
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi sửa hội viên: " + ex.Message);
            }
        }
    }
}
