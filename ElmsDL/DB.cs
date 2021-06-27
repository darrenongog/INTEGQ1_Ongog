//using System;
//using MySql.Data.MySqlClient;
//using System.Collections.Generic;
//using System.Text;

//namespace ElmsDL
//{
//    public class DB
//    {



//        static public void connect(string EmployeeName, string EmployeeID)
//        {
//            string myConnectionString = "server=localhost;database=facultymem;uid=root;pwd=pwd;";


//            MySqlConnection cnn = new MySqlConnection(myConnectionString);


//            {
//                var InputStatement = "INSERT INTO members " +
//                    "(Name, EmployeeList) " +
//                    "VALUES ('@EmployeeName', '@EmployeeID')";
//                MySqlCommand inputCommand = new MySqlCommand(InputStatement, cnn);
//                inputCommand.Parameters.AddWithValue("@EmployeeName", name);
//                inputCommand.Parameters.AddWithValue("@EmployeeID", IDnum);

//                cnn.Open();
//                inputCommand.ExecuteNonQuery();
//                cnn.Close();

//                Console.WriteLine("Successfully recorded");
//            }
//        }

//    }

//}

