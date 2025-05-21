using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Products.ConcreteProducts
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows-style Button.");
            // Imagine actual Windows UI rendering logic here
        }
    }
}
