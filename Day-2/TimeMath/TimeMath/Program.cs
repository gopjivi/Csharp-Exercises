// See https://aka.ms/new-console-template for more information
Console.Write("Enter the time (hh:mm): ");
string timeInput = Console.ReadLine().Trim();
Console.Write("Enter the number of minutes to add: ");
int minutesToAdd = int.Parse(Console.ReadLine());
TimeSpan inputTime = TimeSpan.Parse(timeInput);
TimeSpan newTime = inputTime.Add(TimeSpan.FromMinutes(minutesToAdd));
Console.WriteLine("New time: {0:D2}:{1:D2}", newTime.Hours, newTime.Minutes);