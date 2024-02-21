using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp11
{
    internal class Program
    {
        
        public static string connectionStr => "Data Source=DESKTOP-BRQ9LQE\\SQLEXPRESS;Initial Catalog=Journal;Integrated Security=True;Connect Timeout=30;";
        static void Main(string[] args)
        { 
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                char q = ' ';
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                Console.WriteLine("Ok!");
                while (q != 'e')
                {  
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine("1 - ex1, 2 - ex2, 3 - ex3, 4 - ex4, 5 - ex5 e -exit\n");
                    q = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (q)
                    {

                        case '1':
                            {
                                string query = "SELECT * FROM Students";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case '2':
                            {
                                string query = "SELECT Fullname FROM Students";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case '3':
                            {
                                string query = "SELECT GroupName FROM Students";
                                showTableInfo(query, connection);
                                Console.ReadKey();

                            }
                            break;

                        case '4':
                            {
                                string query = "SELECT SunbjMinAward FROM Students";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case '5':
                            {

                                string query = "SELECT SunbjMaxAward FROM Students";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;
                        case '6':
                            {
                                string query = "SELECT Fullname FROM Students WHERE AwerageAward > 6";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case '7':
                            {
                                string query = "SELECT DISTINCT Fullname FROM Students WHERE MIN(AwerageAward) = (SELECT AwerageAward FROM Students)";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;
                        case '8':
                            {
                                string query = "SELECT  MIN(AwerageAward) FROM Students ";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;
                        case '9':
                            {
                                string query = "SELECT  MAX(AwerageAward) FROM Students ";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case '0':
                            {
                                string query = "SELECT  MAX(AwerageAward) FROM Students ";
                                showTableInfo(query, connection);
                                Console.ReadKey();
                            }
                            break;

                        case 'e':
                            {
                                q = 'e';
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
        public static void showTableInfo(string query, SqlConnection connctinon)
        {
            using (var cmd = new SqlCommand(query, connctinon))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader[i] + "    ");
                    Console.WriteLine();
                }
                reader.Close();
            }
        }
    }
}