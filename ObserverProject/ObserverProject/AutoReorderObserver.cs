using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverProject
{
    internal class AutoReorderObserver : IObserver
    {
        public void Update(string productName, int stock)
        {
            if (stock < 5)
            {
                Console.WriteLine($"[AUTOREORDER] Stock for {productName} is low ({stock}). Auto-reordering...");
            }
        }
    }
}
