// See https://aka.ms/new-console-template for more information
// Create a list of Person objects
using LINQandObjects;

List<Person> people = new List<Person>
        {
            new Person("Alice", "Female", 30, "New York"),
            new Person("Bob", "Male", 24, "Los Angeles"),
            new Person("Charlie", "Non-Binary", 28, "Chicago"),
            new Person("David", "Male", 35, "Houston"),
            new Person("Eve", "Female", 22, "Phoenix"),
            new Person("Frank", "Male", 40, "Philadelphia"),
            new Person("Grace", "Female", 33, "San Antonio"),
            new Person("Hannah", "Female", 29, "San Diego"),
            new Person("Ian", "Male", 27, "Dallas"),
            new Person("Judy", "Female", 26, "San Jose"),
            new Person("Kevin", "Male", 32, "Austin"),
            new Person("Liam", "Male", 31, "San Francisco"),
            new Person("Mia", "Female", 24, "Columbus"),
            new Person("Nina", "Female", 37, "Indianapolis"),
            new Person("Oscar", "Male", 29, "Seattle"),
            new Person("Paul", "Male", 45, "Seattle"),
            new Person("Quinn", "Non-Binary", 23, "Denver"),
            new Person("Rita", "Female", 34, "Washington"),
            new Person("Sam", "Male", 39, "Boston"),
            new Person("Tina", "Female", 30, "El Paso"),
            new Person("Ulysses", "Male", 28, "Nashville")
        };
//ListMalesUnder25(people);
//ListDistinctHometowns(people);
//ListPeopleByHometownAndName(people);
//DisplayAverageAgeByGender(people);
DisplayHometownCounts(people);
// Method to list and display males under 25
static void ListMalesUnder25(List<Person> people)
{
    var malesUnder25 = people
        .Where(person => person.Gender == "Male" && person.Age < 25)
        .ToList();

    Console.WriteLine("Males under 25:");
    foreach (var person in malesUnder25)
    {
        person.DisplayInfo();
    }
}
static void ListDistinctHometowns(List<Person> people)
{
    var distinctHometowns = people
        .Select(person => person.Hometown) // Select the hometowns
        .Distinct() // Remove duplicates
        .OrderBy(hometown => hometown) // Order by ascending
        .ToList(); // Convert to a list

    Console.WriteLine("Distinct Hometowns in Ascending Order:");
    foreach (var hometown in distinctHometowns)
    {
        Console.WriteLine(hometown);
    }
}

static void ListPeopleByHometownAndName(List<Person> people)
{
    var sortedPeople = people
        .OrderBy(person => person.Hometown) // First sort by hometown
        .ThenBy(person => person.Name)     // Then sort by name within each hometown
        .ToList(); // Convert to a list

    Console.WriteLine("People sorted by hometown and then by name:");
    foreach (var person in sortedPeople)
    {
        person.DisplayInfo();
    }
}

// Method to display average age of all women and all men
static void DisplayAverageAgeByGender(List<Person> people)
{
    var averageAgeWomen = people
        .Where(person => person.Gender == "Female")
        .Average(person => person.Age);

    var averageAgeMen = people
        .Where(person => person.Gender == "Male")
        .Average(person => person.Age);

    Console.WriteLine($"Average age of all women: {averageAgeWomen:F2}");
    Console.WriteLine($"Average age of all men: {averageAgeMen:F2}");
}

static void DisplayHometownCounts(List<Person> people)
{
    var hometownCounts = people
        .GroupBy(person => person.Hometown) // Group by hometown
        .Select(group => new { Hometown = group.Key, Count = group.Count() }) // Project result
        .OrderBy(h => h.Hometown) // Optional: Order by hometown
        .ToList(); // Convert to a list

    Console.WriteLine("Hometowns and the number of people from each:");
    foreach (var item in hometownCounts)
    {
        Console.WriteLine($"{item.Hometown}: {item.Count}");
    }
}