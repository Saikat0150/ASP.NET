using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Operation_using_console_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "data source=SAIKAT-SANIL\\SQL2019;Database=B15;Trusted_Connection=true";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM form", conn);
                // Add the parameters.
                //command.Parameters.Add(new SqlParameter("0", 1));
                /* Get the rows and display on the screen! 
                 * This section of the code has the basic code
                 * that will display the content from the Database Table
                 * on the screen using an SqlDataReader. */

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Roll\t Name\t\tPhone\t\tAddress\t\\t Age\t\t Gender");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3} \t {4} \t {5}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]));
                    }
                }
                Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                Console.ReadLine();
                Console.Clear();

                /* Above code was used to Display the data from the Database table!
                 * This following section explains the key features to use 
                 * to add the data to the table. This is an example of another
                 * SQL Command (INSERT INTO), this will teach the usage of parameters and connection.*/

                SqlCommand update = new SqlCommand("UPDATE form SET Age=@0,Gender=@1 WHERE Roll=@2",conn);
                update.Parameters.Add(new SqlParameter("0", 23));
                update.Parameters.Add(new SqlParameter("1", "M"));
                update.Parameters.Add(new SqlParameter("2", 18));
                Console.Write("Update Successfull ");
                Console.WriteLine(update.ExecuteNonQuery());

                //delete
                Console.WriteLine("Press Enter to execute delete");
                Console.ReadLine();
                SqlCommand delete = new SqlCommand("DELETE form WHERE Roll=@0", conn);
                delete.Parameters.Add(new SqlParameter("0", 2));
                Console.Write("Delete Successfull ");
                Console.WriteLine(delete.ExecuteNonQuery());


                Console.WriteLine("INSERT INTO command");

                // Create the command, to insert the data into the Table!
                // this is a simple INSERT INTO command!

                SqlCommand insertCommand = new SqlCommand("INSERT INTO form (Roll, Name, Phone, Address, Age, Gender) VALUES (@0, @1, @2, @3, @4, @5)", conn);

                // In the command, there are some parameters denoted by @, you can 
                // change their value on a condition, in my code they're hardcoded.

                insertCommand.Parameters.Add(new SqlParameter("0", 5));
                insertCommand.Parameters.Add(new SqlParameter("1", "Som"));
                insertCommand.Parameters.Add(new SqlParameter("2", 7009847920));
                insertCommand.Parameters.Add(new SqlParameter("3", "Chennai"));
                insertCommand.Parameters.Add(new SqlParameter("4", 26));
                insertCommand.Parameters.Add(new SqlParameter("5", "M"));

                // Execute the command, and print the values of the columns affected through
                // the command executed.

                //Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());
                Console.WriteLine("Done! Press enter to move to the next step");
                Console.ReadLine();
                Console.Clear();
                /* In this section there is an example of the Exception case
                 * Thrown by the SQL Server, that is provided by SqlException 
                 * Using that class object, we can get the error thrown by SQL Server.
                 * In my code, I am simply displaying the error! */
                Console.WriteLine("Now the error trial!");

                // try block
                try
                {
                    // Create the command to execute! With the wrong name of the table (Depends on your Database tables)
                    SqlCommand errorCommand = new SqlCommand("SELECT * FROM someErrorColumn", conn);
                    // Execute the command, here the error will pop up!
                    // But since we're catching the code block's errors, it will be displayed inside the console.
                    errorCommand.ExecuteNonQuery();
                }
                // catch block
                catch (SqlException er)
                {
                    // Since there is no such column as someErrorColumn (Depends on your Database tables)
                    // SQL Server will throw an error.
                    Console.WriteLine("There was an error reported by SQL Server, " + er.Message);
                }
            }
            // Final step, close the resources flush dispose them. ReadLine to prevent the console from closing.
            Console.ReadLine();
        }
    }
}
