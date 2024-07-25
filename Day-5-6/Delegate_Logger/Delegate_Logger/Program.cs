// See https://aka.ms/new-console-template for more information
using Delegate_Logger;

public delegate void LoggingOperation(string message);
class Program
{
    static void Main()
    {
        // Create an instance of the Logger class
        Logger logger = new Logger();

        // Create delegate instances for each logging method
        LoggingOperation logInfo = logger.Info;
        LoggingOperation logWarning = logger.Warning;
        LoggingOperation logError = logger.Error;

        // Use the delegate to call each logging method
        logInfo("This is an informational message.");
        logWarning("This is a warning message.");
        logError("This is an error message.");
        // Create a delegate for an anonymous method
        LoggingOperation alertLog = delegate (string message)
        {
            Console.WriteLine("[ALERT] " + message);
        };

        // Test the anonymous method
        alertLog("This is an alert message.");
    }
}