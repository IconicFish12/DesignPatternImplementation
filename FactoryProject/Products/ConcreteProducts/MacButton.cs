using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Products.ConcreteProducts
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac-style Button.");
            // Imagine actual Mac UI rendering logic here
        }
    }
}
