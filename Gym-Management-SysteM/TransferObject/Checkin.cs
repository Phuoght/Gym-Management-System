using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Checkin
    {
        public int MemberID { get; set; }
        public DateTime CheckInTime { get; set; }
        public Checkin(int memberId, DateTime checkInTime)
        {
            MemberID = memberId;
            CheckInTime = checkInTime;
        }
    }
}
