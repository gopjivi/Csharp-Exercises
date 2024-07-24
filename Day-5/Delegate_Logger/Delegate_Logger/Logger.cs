using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Logger
{
    public class Logger
    {
        // Method to log informational messages
        public void Info(string message)
        {
            Console.WriteLine("[INFO] " + message);
        }

        // Method to log warning messages
        public void Warning(string message)
        {
            Console.WriteLine("[WARNING] " + message);
        }

        // Method to log error messages
        public void Error(string message)
        {
            Console.WriteLine("[ERROR] " + message);
        }
    }
}
