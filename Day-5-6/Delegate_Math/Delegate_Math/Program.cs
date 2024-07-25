// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Delegate_Math;

public delegate double MathOperation(double a, double b);
class Program
{
    public static void Main(string[] args)
    {

        BasicMath math = new BasicMath();
        MathOperation mathOp = new MathOperation(math.Add);
        Console.WriteLine("enter a value A");
        double a =double.Parse( Console.ReadLine());
        Console.WriteLine("enter a value B");
        double b = double.Parse(Console.ReadLine());
        double addvalue= mathOp(a,b);
        Console.WriteLine("addition Value " + addvalue);

        MathOperation subract = (math.Subtract);
        double subractvalue = subract(a, b);
        Console.WriteLine("subract Value " + subractvalue);

        MathOperation multiply = (math.Multiply);
        double multiplyvalue = multiply(a, b);
        Console.WriteLine("multiply Value " + multiplyvalue);

        MathOperation divide = (math.Divide);
        double dividevalue = divide(a, b);
        Console.WriteLine("divide Value " + dividevalue);

    }
}


