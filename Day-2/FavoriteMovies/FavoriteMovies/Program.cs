// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography.X509Certificates;

List<string> movies = new List<string>();
string movie;
Console.WriteLine("Enter your favorite movies. Press Enter without typing a movie name to stop.");

while (true) 
{
    Console.Write("Enter a movie name: ");
    movie = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(movie))
    {
        break;
    }

    movies.Add(movie);
}
movies.Sort();
Console.WriteLine("Sorted movies");
for(int i=0;i<movies.Count;i++)
{
    Console.WriteLine(movies[i]);
}



Console.WriteLine("Enter word to do partial search");
string name = Console.ReadLine();

var searchResults = movies
                        .Where(m => m.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

Console.WriteLine("\nSearch results:");
if (searchResults.Count > 0)
{
    foreach (var result in searchResults)
    {
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("No matches found.");
}




Console.WriteLine("Enter name to do Exact search");
string exactName = Console.ReadLine();
bool movieFound = movies.Contains(exactName, StringComparer.OrdinalIgnoreCase);

if (movieFound)
{
    Console.WriteLine($"The movie '{exactName}' was found.");
}
else
{
    Console.WriteLine($"The movie '{exactName}' was not found.");
}