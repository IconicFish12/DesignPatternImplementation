using SingletonProject.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.ImplementExample
{
    public class Logger
    {
        public void LogMessage(string message)
        {
            string app = ConfigurationManager.Instance.getSettings("ApplicationName");
            Console.WriteLine($"[{app}] Logger: {message}");
        }

    }
}
