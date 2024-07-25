// See https://aka.ms/new-console-template for more information
using PaymentProcessingApp;

public delegate bool PaymentHandler(string accountNumber, double amount);

class Program
{
    static void Main()
    {
        PaymentMethods paymentMethods = new PaymentMethods();

        // Create delegate instances for each payment method
        PaymentHandler mastercardHandler = paymentMethods.ProcessMastercardPayment;
        PaymentHandler visaHandler = paymentMethods.ProcessVisaPayment;
        PaymentHandler discoverHandler = paymentMethods.ProcessDiscoverPayment;

        // Test the delegates with sample data
       // ProcessPayment(mastercardHandler, "1234-5678-9876", 100.00);
        //ProcessPayment(visaHandler, "2345-6789-8765", 200.00);
        // ProcessPayment(discoverHandler, "3456-7890-7654", 300.00);

        // Test Mastercard payment
        bool isMastercardOk = ProcessPayment(mastercardHandler, "1234-1111-2222-1234", 100.00);
        if (!isMastercardOk)
        {
            Console.WriteLine("[ALERT] Mastercard payment processing failed");
        }

        // Test Visa payment
        bool isVisaOk = ProcessPayment(visaHandler, "2345-6789-1234-5678", 200.00);
        if (!isVisaOk)
        {
            Console.WriteLine("[ALERT] Visa payment processing failed");
        }

        // Test Discover payment
        bool isDiscoverOk = ProcessPayment(discoverHandler, "3456-7890-1234-5678", 300.00);
        if (!isDiscoverOk)
        {
            Console.WriteLine("[ALERT] Discover payment processing failed");
        }

        bool ProcessPayment(PaymentHandler paymentHandler, string accountNumber, double amount)
        {
            return paymentHandler(accountNumber,amount);
        }
    }
}
