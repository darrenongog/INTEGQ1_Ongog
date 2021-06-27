using ElmsDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElmsBL
{
    public class Admin
    {
        public static void LoginasAdmin()
        {
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|          Login As Admin          |");
            Console.WriteLine("|----------------------------------|");

            
                UserData admin = new UserData();

                var username = _username();
                var password = _password();

                if (username == admin.AdminUserName && password == admin.AdminPassword)
                {
                    Console.WriteLine("Login Successful!");
                Console.ReadKey();
                AdminChoice();

                }
                else
                {
                    
                }
  

        }

        public static void ValidateAdminUser()
        {
            Console.Clear();
        int logcount = 0;
            for (int i = 0; i < 3; i++)
            {

                LoginasAdmin();
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

        public static void AdminChoice()
        {
            Console.Clear();
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|           Administrator          |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("\a\a Please choose Actions.");
            Console.WriteLine("1. Show Pending Leave Request");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Action: ");
            int action = int.Parse(Console.ReadLine());

            if(action == 1)
            {
                LeaveForm showrequest = new LeaveForm();
                showrequest.ShowLeaveRequest();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Application Exiting....");
                Console.ReadKey();
            }


        }
        private static string _username()
        {
            Console.WriteLine("Enter Username: ");
            var username = Console.ReadLine();
            return username;
        }

        private static string _password()
        {
            Console.WriteLine("Enter Password: ");
            var password = Console.ReadLine();
            return password;
        }


    }
}
