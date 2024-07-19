// See https://aka.ms/new-console-template for more information
using ManagingFamily;

List<Person> people = new List<Person>();
string name;
int age;
string gender;

Console.WriteLine("Welcome to ManagingFamily!");

while (true)
{
    Console.Write("Enter the name of the person (or press Enter to stop): ");
    name = Console.ReadLine().Trim();
    if (string.IsNullOrEmpty(name))
    {
        break;
    }

    Console.Write("Enter the age of the person: ");
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.Write("Invalid input. Please enter a valid age: ");
    }

    Console.Write("Enter the gender of the person: ");
    gender = Console.ReadLine().Trim();

    Person person = new Person(name, age, gender);
    people.Add(person);
}

while (true)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Display all people");
    Console.WriteLine("2. Display all people of a selected gender");
    Console.WriteLine("3. Display all people between a specified age range");
    Console.WriteLine("4. Exit");
    string choice = Console.ReadLine().Trim();

    if (choice == "1")
    {
        Console.WriteLine("\nDisplaying all people:");
        foreach (var person in people)
        {
            person.Display();
        }
    }
    else if (choice == "2")
    {
        Console.Write("Enter the gender to search for: ");
        string searchGender = Console.ReadLine().Trim();

        var filteredByGender = people
            .Where(p => p.Gender.Equals(searchGender, StringComparison.OrdinalIgnoreCase))
            .ToList();

        Console.WriteLine("\nDisplaying people of gender '{0}':", searchGender);
        if (filteredByGender.Any())
        {
            foreach (var person in filteredByGender)
            {
                person.Display();
            }
        }
        else
        {
            Console.WriteLine("No matches found.");
        }
    }
    else if (choice == "3")
    {
        Console.Write("Enter the minimum age: ");
        int minAge;
        while (!int.TryParse(Console.ReadLine(), out minAge))
        {
            Console.Write("Invalid input. Please enter a valid minimum age: ");
        }

        Console.Write("Enter the maximum age: ");
        int maxAge;
        while (!int.TryParse(Console.ReadLine(), out maxAge))
        {
            Console.Write("Invalid input. Please enter a valid maximum age: ");
        }

        var filteredByAge = people
            .Where(p => p.Age >= minAge && p.Age <= maxAge)
            .ToList();

        Console.WriteLine("\nDisplaying people between ages {0} and {1}:", minAge, maxAge);
        if (filteredByAge.Any())
        {
            foreach (var person in filteredByAge)
            {
                person.Display();
            }
        }
        else
        {
            Console.WriteLine("No matches found.");
        }
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select '1', '2', '3', or '4'.");
    }
}

Console.WriteLine("\nExiting. Press any key to exit.");
Console.ReadKey();
       
