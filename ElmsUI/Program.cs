
using ElmsBL;
using ElmsDL;
using System;
using System.Collections.Generic;

namespace ElmsUI
{
    class Program
    {
        static List<string> actions = new List<string>()
            { "Leave Request (type 0)", "Login as Admin (type 1)", "exit app (type 2)" };

        static void Main(string[] args)
        {
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| Employee Leave Management System |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("Please Enter to Proceed");
            Console.ReadKey();
            GetUserAction();
        }

        public static void GetUserAction()
        {
            Console.Clear();
            ChooseAction();
            Console.Write("Action: ");
            int UserAction = int.Parse(Console.ReadLine());

            if (UserAction == 0)
            {
                LeaveRequest();
            }else if(UserAction == 1)
            {
                Admin admin = new Admin();
                Admin.ValidateAdminUser();
            }
            else
            {
                Console.WriteLine("Application Exiting....");
                Console.ReadKey();
            }
            
        }

        public static void ChooseAction()
        {
            foreach(var action in actions)
            {
                Console.WriteLine(action);
                
            }   
        }

        public static void LeaveRequest()
        {
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|        Leave Request Page        |");
            Console.WriteLine("|----------------------------------|");
            ValidateEmployee.ValidateEmployees();

        }

       

      
       
        

    }
}
