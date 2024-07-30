using EmployeesInformation.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace EmployeesInformation
{
    public class EmployeesDataStore
    {
      public static  List<Employee> Employees { get; set; }

        static string connectionString = "Server=WSAMZN-8P0C1RTJ;Initial Catalog=EmployeesDatabase;User ID=sa;Password=Password@123;";
       
        public static List<Employee> GetEmployees()
        {
             List<Employee> Employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from Employee";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            Employee emp = new Employee
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                JobTitle = reader.GetString(2),
                                Salary = reader.GetDecimal(3)
                            };
                            Employees.Add(emp);
                        }
                        catch (Exception ex)
                        {
                            // Log or handle individual record conversion errors if needed
                            Console.WriteLine($"Error reading employee record: {ex.Message}");
                        }
                    }
                }
                //connection.Close();
            }
           return Employees;
           
        }
        public static Employee GetEmployeeById(int id)
        {
            Employee employee = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from Employee where Id= @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            employee = new Employee
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                JobTitle = reader.GetString(2),
                                Salary = reader.GetDecimal(3)
                            };
                          
                        }
                        catch (Exception ex)
                        {
                            // Log or handle individual record conversion errors if needed
                            Console.WriteLine($"Error reading employee record: {ex.Message}");
                        }
                    }
                }
                //connection.Close();
            }
            return employee;

        }

        public static bool DeleteEmployeeById(int id)
        {
           
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = " Delete from Employee where Id= @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
                else
                {
                    return result;
                }

            }
            return result;

        }

        public static bool InsertEmployee(string name,string jobTitle,decimal salary)
        {

            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employee ( Name, JobTitle, Salary) VALUES (@Name, @JobTitle, @Salary)";
                
            SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@JobTitle", jobTitle);
                command.Parameters.AddWithValue("@Salary", salary);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
                else
                {
                    return result;
                }

            }
            return result;

        }
    }
}
