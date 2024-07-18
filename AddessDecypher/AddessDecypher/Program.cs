// See https://aka.ms/new-console-template for more information
using System.Globalization;

string address = "Betty Smallwood|3329 Duchess|Erath, Texas";
string[] addressline = address.Split('|');
Console.WriteLine("Name :" + addressline[0]);
Console.WriteLine("Address :" + addressline[1]);

string[] addressline1= addressline[2].Split(',');
Console.WriteLine("City :" + addressline1[0]);
Console.WriteLine("State :" + addressline1[1]);
