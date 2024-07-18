// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Choose the Product Code\" BG-127,WRTR-28,GUAC-8\"");
string productCode = Console.ReadLine();
Console.WriteLine("Enter the Quantity");
int quantity = int.Parse(Console.ReadLine());
double price=0;

int productQuantity = Convert.ToInt32(quantity);
switch (productCode)
{
    case "BG-127":
      if(quantity>=51)
        {
            price = 14.49;
        }
      else if(quantity>=25 )
        {
            price = 17.00;
        }
      else 
        {
            price =14.49;
        }
        break;
    case "WRTR-28":
        if (quantity >= 51)
        {
            price = 99.99;
        }
        else if (quantity >= 25)
        {
            price = 113.75;
        }
        else
        {
            price = 125.00;
        }
        break;
    case "GUAC-8":
        if (quantity >= 51)
        {
            price = 7.49;
        }
        else if (quantity >= 25)
        {
            price = 8.99;
        }
        else
        {
            price = 8.99;
        }
        break;

}


if (productQuantity>=250)
{
    double totalPrice = price * productQuantity;
    double discountAmount = totalPrice * 0.15;
    double finalAmount = totalPrice - discountAmount;
    Console.WriteLine("Discount Price " + discountAmount);
    Console.WriteLine("Amount to be paid " + finalAmount);
}
else
{
    Console.WriteLine("Amount to be paid " + productQuantity* price);
}