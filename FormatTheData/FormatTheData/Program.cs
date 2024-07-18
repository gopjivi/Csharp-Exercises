// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Runtime.InteropServices.JavaScript.JSType;

string name = "Zachary";
DateTime bday = new DateTime(1990, 5, 20);
decimal pay = 69759.25M;

Console.WriteLine(
   "V1- {0} was born on {1:dd-MM-yyyy} and earns {2:C}",
   name, bday, pay);

Console.WriteLine(
   $"V2- {name} was born on {bday:dd-MM-yyyy} and earns {pay:C}");

Console.WriteLine(pay.ToString("C",
                  new System.Globalization.CultureInfo("en-US")));

string customFormat = "MMMM dd, yyyy (dddd)";
Console.WriteLine(bday.ToString(customFormat));
Console.WriteLine(bday.ToString("%M"));