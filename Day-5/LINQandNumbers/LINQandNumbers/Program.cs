// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System;

int[] numbers = new int[50];
Random rd = new Random();

//List the even numbers in original order

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rd.Next(1,10000);
    Console.WriteLine(numbers[i]);
}

//List the numbers in ascending order
numbers = (from num in numbers orderby num ascending select num).ToArray();
Console.WriteLine("..........Asecending Order...............");
for (int i = 0; i < numbers.Length; i++)
{ 
    Console.WriteLine(numbers[i]);
}

//List the numbers under 100 in descending order
//numbers = (from num in numbers select num).Where(num=>num<100).ToArray();
//for (int i = 0; i < numbers.Length; i++)
//{
  //  Console.WriteLine(numbers[i]);
//}

//Find the minimum number, the maximum number, and the sum of all the numbers  
int minNumber = (from num in numbers select num).Min();
Console.WriteLine("Min Number " + minNumber);
    
int maxNumber = (from num in numbers select num).Max();
Console.WriteLine("Max Number " + maxNumber);


int sumNumber = (from num in numbers select num).Sum();
Console.WriteLine("Sum Number " + sumNumber);