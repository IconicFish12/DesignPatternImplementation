using SingletonProject.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.ImplementExample
{
    public class DatabaseService
    {
        public void Connect()
        {
            string connString = ConfigurationManager.Instance.getSettings("ConnectionString");
            Console.WriteLine($"DatabaseService: Connecting with {connString}");
        }
    }
}
