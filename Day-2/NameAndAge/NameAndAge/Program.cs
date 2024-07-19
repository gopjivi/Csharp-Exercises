// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

for (int i=0;i<3;i++)
{ 
Console.WriteLine("Enter Your Name");
string name = Console.ReadLine();
Console.WriteLine("Enter your age on 31 st December 2024");
int age = int.Parse(Console.ReadLine());
int year=GetBirthYear(age);
Console.WriteLine("{0} was born in {1}", name, year);
    Console.WriteLine("Do you want to enter another (yes/no)?");
    string answer = Console.ReadLine();
    if(answer.ToLower()=="yes")
    {
        continue;
    }
    else
    {
        break;
    }
}
 static int GetBirthYear(int age)
{

    int birthyear = 2024 - age;
    return birthyear;
}