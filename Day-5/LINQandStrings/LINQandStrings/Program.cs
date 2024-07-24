// See https://aka.ms/new-console-template for more information
// Create a list of fruits and vegetables
using System.Collections.Generic;

List<string> fruitsAndVegetables = new List<string>
        {
            "Apple",
            "Banana",
            "Carrot",
            "Tomato",
            "Cucumber",
            "Orange",
            "Strawberry",
            "Broccoli",
            "Spinach",
            "Potato",
            "Grapes",
            "Mango",
            "Blueberry",
            "Pineapple",
            "Onion",
            "Garlic",
            "Pepper",
            "Peach",
            "Pear",
            "Lettuce"
        };

// Print the list of fruits and vegetables
Console.WriteLine("List of Fruits and Vegetables:");
foreach (string item in fruitsAndVegetables)
{
    Console.WriteLine(item);
}

//List all strings that start with a B or b.
//fruitsAndVegetables = (from b in fruitsAndVegetables select b).Where(b=>b.StartsWith('B') || b.StartsWith('b')).ToList();

Console.WriteLine("List of Fruits and Vegetables with b:");
foreach (string item in fruitsAndVegetables)
{
    Console.WriteLine(item);
}

//List all strings that contain the word “betty”
fruitsAndVegetables = (from b in fruitsAndVegetables
                       select b).Where(b => b.Contains("berry")).ToList();


Console.WriteLine("List of Fruits and Vegetablesthat contain the word “berry”");
foreach (string item in fruitsAndVegetables)
{
    Console.WriteLine(item);
}

//List strings that start with the letters A-M

var startsWithAM = fruitsAndVegetables.Where(item =>
            item[0] >= 'A' && item[0] <= 'M' ||
            item[0] >= 'a' && item[0] <= 'm').ToList();

// Print the filtered list
Console.WriteLine("Fruits and Vegetables starting with letters A-M:");
foreach (string item in startsWithAM)
{
    Console.WriteLine(item);
}

//How many strings start with the letters N-Z
// Count the number of strings that start with the letters N-Z
int countNZ = fruitsAndVegetables.Count(item =>
    item[0] >= 'N' && item[0] <= 'Z' ||
    item[0] >= 'n' && item[0] <= 'z');

// Print the count
Console.WriteLine($"Number of fruits and vegetables starting with letters N-Z: {countNZ}");


// Find the longest string in the list
string longestString = fruitsAndVegetables.OrderByDescending(item => item.Length).First();

// Print the longest string
Console.WriteLine($"The longest string in the list is: {longestString}");
    