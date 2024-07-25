// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;
namespace NorthwindGrocery_ConsoleApp
{
    class Program
    {
       static string connetionString = "Server=WSAMZN-8P0C1RTJ;Initial Catalog=demo;User Id=sa;Password=Password@123;";

        static void Main(string[] args)
        {
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("choose option from Menu");
                Console.WriteLine("1 - List all categories");
                Console.WriteLine("2 - List products in a specific category");
                Console.WriteLine("3 - List products in a price range");
                Console.WriteLine("4 - List all suppliers");
                Console.WriteLine("5 - List products from a specific category");
                Console.WriteLine("6 - Quit");
                int menuOption = int.Parse(Console.ReadLine());


                switch (menuOption)
                {
                    case 1:
                        ListAllCategories();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Category Name");
                        string categoryName = Console.ReadLine();
                        GetCategoriesByName(categoryName);
                        break;
                    case 3:
                        Console.WriteLine("Enter the minimum price range");
                        decimal minimumRange = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the maximun price range");
                        decimal maximunRange = decimal.Parse(Console.ReadLine());
                        ListProductsInPriceRange(minimumRange, maximunRange);
                        break;
                    case 4:
                        ListAllSuppliers();
                        break;
                    case 5:
                        Console.WriteLine("Enter the SupplierID");
                        int supplierID = int.Parse(Console.ReadLine());
                        ListProductsFromSupplier(supplierID);
                        break;
                    case 6:
                        isTrue = false;
                        break;
                }
            }
        }
        public static void ListAllCategories()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CategoryName FROM Categories", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["CategoryName"]);
                }
            }
        }

        public static void GetCategoriesByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT ProductName FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID WHERE c.CategoryName = @CategoryName",
                    connection);
                command.Parameters.AddWithValue("@CategoryName", name);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ProductName"]);
                }
            }
        }

        static void ListProductsInPriceRange(decimal minPrice, decimal maxPrice)
        {
           

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT ProductName, UnitPrice FROM Products WHERE UnitPrice BETWEEN @MinPrice AND @MaxPrice",
                    connection);
                command.Parameters.AddWithValue("@MinPrice", minPrice);
                command.Parameters.AddWithValue("@MaxPrice", maxPrice);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ProductName"]} - {reader["UnitPrice"]:C}");
                }
            }
        }

        static void ListAllSuppliers()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CompanyName FROM Suppliers", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["CompanyName"]);
                }
            }
        }

        static void ListProductsFromSupplier(int supplierID)
        {
           
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT ProductName FROM Products WHERE SupplierID = @SupplierID",
                    connection);
                command.Parameters.AddWithValue("@SupplierID", supplierID);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ProductName"]);
                }
            }
        }
    }
   
}