using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverProject
{
    internal class LoggerObserver : IObserver
    {
        private const string LogFilePath = "log.txt";

        public void Update(string productName, int stock)
        {
            string log = $"[{DateTime.Now}] Stock update: {productName} -> {stock}";
            File.AppendAllText(LogFilePath, log + Environment.NewLine);
            Console.WriteLine($"[LOGGER] {log}");
        }
    }
}
