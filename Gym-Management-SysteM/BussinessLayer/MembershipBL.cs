using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class MembershipBL
    {
        private MembershipDL membershipDL;
        public MembershipBL()
        {
            membershipDL = new MembershipDL();
        }
        public List<Membership> GetMemberships()
        {
            try
            {
                return membershipDL.GetMemberships();
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi lấy danh sách hội viên: " + ex.Message);
            }
        }
        public void AddMembership(Membership membership)
        {
            try
            {
                membershipDL.Add(membership);
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi thêm hội viên: " + ex.Message);
            }
        }
        public void DeleteMembership(int id)
        {
            try
            {
                membershipDL.DeleteMembership(id);
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi xóa hội viên: " + ex.Message);
            }
        }
        public void EditMembership(Membership membership)
        {
            try
            {
                membershipDL.EditMembership(membership);
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi sửa hội viên: " + ex.Message);
            }
        }
    }
}
