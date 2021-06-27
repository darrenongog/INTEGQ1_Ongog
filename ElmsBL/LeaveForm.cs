using ElmsDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElmsBL
{
    public class LeaveForm
    {
        static List<string> LeaveType = new List<string>()
        {"Emergency Leave",  " Regular Leave", "Birthday Leave", "Vacation Leave",
            "Sick Leave", "Maternity Leave", "Faternity Leave"};


        public void AddLeave()
        {
            Console.Clear();
            ShowLeaveType();
            Console.WriteLine("Enter Your FullName (Ex: Juan Dela Cruz):");
            var fullname = Console.ReadLine();
            Console.WriteLine("Enter Your Leave type you apply: ");
            var leavetype = Console.ReadLine();
            Console.WriteLine("How many day/s of leave are applying? ");
            var daysofleave = Console.ReadLine();
            Console.WriteLine("Reason of Applying for leave: ");
            var reasonofleave = Console.ReadLine();
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|    Please Review your Details    |");
            Console.WriteLine("|----------------------------------|");

            Console.WriteLine("Status: Pending");
            Console.WriteLine("Name:" + fullname);
            Console.WriteLine("Type of Leave:" + leavetype);
            Console.WriteLine("Day/s:" + daysofleave);
            Console.WriteLine("Reason:" + reasonofleave);
            
        }

        public List<string> LeaveRequest = new List<string>()
        {
            "Pending","Darren Ongog", "Emergency Leave", "10", "Health Issue"
        };

        public void ShowLeaveRequest()
        {
            foreach(var showleave in LeaveRequest)
            {
                Console.WriteLine(showleave);
                
            }
        }

        public void ShowLeaveType()
        {
            foreach (var leavetype in LeaveType)
            {
                Console.WriteLine(leavetype);
            }
        }
    }
}
