using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverProject
{
    internal class AdminObserver : IObserver
    {
        public void Update(string productName, int stock)
        {
            Console.WriteLine($"[ADMIN] Notification: Stock for {productName} is now {stock}");
        }
    }
}
