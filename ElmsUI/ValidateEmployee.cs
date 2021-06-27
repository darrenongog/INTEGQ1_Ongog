using ElmsBL;
using ElmsDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElmsUI
{
    public class ValidateEmployee
    {

        public static void LeaveChoice()
        {
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|        Leave Request Page        |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("1. Add Leave Request");
            Console.WriteLine("2. Show Leave Request");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Action (Please Enter a Number) :");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                AddLeaveRequest();
            }else if (action == 2)
            {
                LeaveForm showleave = new LeaveForm();
                showleave.ShowLeaveRequest();
            }else if (action == 3)
            {
                Console.WriteLine("Application Exiting ...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Application Exiting ...");
                Console.ReadKey();
            }

            

        }
        private static string employeename()
        {
            Console.WriteLine("Please type your Fullname with No spaces.");
            Console.WriteLine(" (Ex: juandelacruz )");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            return name;
        }

        private static int employeeid()
        {
            Console.Write("Enter your Employee ID Number(Must be in Numbers):");
            int IDnum = int.Parse(Console.ReadLine());
            return IDnum;
        }
        private static string validationPass()
        {
            Console.WriteLine("Please Enter Your Password: ");
            var pass = Console.ReadLine();
            return pass;
        }
        
        
        
        public static void ValidateEmployees()
        {
            UserData userdata = new UserData();
            var name = employeename();
            var pass = validationPass();
            int IDnum = employeeid();


            
                if (name == userdata.Username && IDnum == userdata.EmployeeId && pass == userdata.Password)
                {
                    Console.WriteLine(" Successfully Validated! ");
                    LeaveChoice();
                }
                else
                {
                    Console.WriteLine(" The Name, ID number and Password didnt match any of the employee!");
                    Console.WriteLine("Please try again.");

                }
            

        }
        public static void AddLeaveRequest()
        {
            LeaveForm AddleaveReq = new LeaveForm();
            AddleaveReq.AddLeave();

        }
        

        public static void ValidateUserLog()
        {
            int logcount = 0;
            for (int i = 0; i < 3; i++)
            {
                ValidateEmployees();
                logcount++;
                if (logcount == 3)
                {
                    Console.WriteLine("|----------------------------------|");
                    Console.WriteLine("|       Out of LogIn Attempts      |");
                    Console.WriteLine("|----------------------------------|");
                    Console.WriteLine("\a\a< Please try again later. >");
                    Console.ReadKey();
                }
                else
                {

                }
            }
        }
    }
}
