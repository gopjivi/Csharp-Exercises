// See https://aka.ms/new-console-template for more information
Console.WriteLine("How much are you borrowing?");
string loanAmount = Console.ReadLine();
Console.WriteLine("What is your interest rate?");
string interestRate = Console.ReadLine();
Console.WriteLine("How long is your loan (in years)?");
string loanLength = Console.ReadLine();

double mir = Convert.ToDouble(interestRate) / 1200;
double loanLengthMonth = Convert.ToDouble(loanLength) * 12;

double Estimated_payment = (Convert.ToDouble(loanAmount) * (mir)) / (1 - Math.Pow(1 + mir, -loanLengthMonth));

Console.WriteLine("Your estimated payment is {0:C}", Estimated_payment);