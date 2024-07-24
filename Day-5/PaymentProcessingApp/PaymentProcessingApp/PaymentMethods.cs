using System;

namespace PaymentProcessingApp
{
    public class PaymentMethods
    {
        private static Random random = new Random();

        // Method to process Mastercard payments
        public bool ProcessMastercardPayment(string accountNumber, double amount)
        {
            // Simulate payment processing
            bool success = random.NextDouble() >= 0.10; // 90% chance of success
            Console.WriteLine($"Processing Mastercard payment for account {accountNumber} of amount ${amount}. Success: {success}");
            return success;
        }

        // Method to process Visa payments
        public bool ProcessVisaPayment(string accountNumber, double amount)
        {
            // Simulate payment processing
            bool success = random.NextDouble() >= 0.10; // 90% chance of success
            Console.WriteLine($"Processing Visa payment for account {accountNumber} of amount ${amount}. Success: {success}");
            return success;
        }

        // Method to process Discover payments
        public bool ProcessDiscoverPayment(string accountNumber, double amount)
        {
            // Simulate payment processing
            bool success = random.NextDouble() >= 0.10; // 90% chance of success
            Console.WriteLine($"Processing Discover payment for account {accountNumber} of amount ${amount}. Success: {success}");
            return success;
        }
    }
}
