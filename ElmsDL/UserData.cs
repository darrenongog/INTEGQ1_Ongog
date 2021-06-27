using System;
using System.Collections.Generic;
using System.Text;

namespace ElmsDL
{
    public class UserData
    {
        private string _firstname;
        private string _leavetype;
        private int _daysoleave;
        private string _leavereason;
        

        public string Username = "darrenongog";
        public string Password = "pass";
        public int EmployeeId = 12345;
        public string AdminUserName = "admin123";
        public string AdminPassword = "pass123";

        

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string LeaveType
        {
            get
            {
                return _leavetype;
            }
            set
            {
                _leavetype = value;
            }
        }

        public int DaysofLeave
        {
            get
            {
                return _daysoleave;
            }
            set
            {
                _daysoleave = value;
            }
        }

        public string ReasonofLeave
        {
            get
            {
                return _leavereason;
            }
            set
            {
                _leavereason = value;
            }
        }

    }
}
