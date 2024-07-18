// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter  number a");
string a = Console.ReadLine();
Console.WriteLine("Enter number b");
string b = Console.ReadLine();
int c = Convert.ToInt32(a) + Convert.ToInt32(b);
Console.WriteLine("The Sum of a and b is " + c);

int subractionValue = Convert.ToInt32(a) - Convert.ToInt32(b);
Console.WriteLine("The Subraction of a and b is " + subractionValue);

int multiplyValue = Convert.ToInt32(a) * Convert.ToInt32(b);
Console.WriteLine("The Multiplication of a and b is " + multiplyValue);

int divisionValue = Convert.ToInt32(a) / Convert.ToInt32(b);
Console.WriteLine("The Division of a and b is " + divisionValue);


Console.WriteLine("Double Value");
double sumValue = Convert.ToDouble(a) + Convert.ToDouble(b);
Console.WriteLine("The Sum of a and b is " + sumValue);

double subractionDoubleValue = Convert.ToDouble(a) - Convert.ToDouble(b);
Console.WriteLine("The Subraction of a and b is " + subractionDoubleValue);

double multiplyDoubleValue = Convert.ToDouble(a) * Convert.ToDouble(b);
Console.WriteLine("The Multiplication of a and b is " + multiplyDoubleValue);

double divisionDoubleValue = Convert.ToDouble(a) / Convert.ToDouble(b);
Console.WriteLine("The Division of a and b is " + divisionDoubleValue);




