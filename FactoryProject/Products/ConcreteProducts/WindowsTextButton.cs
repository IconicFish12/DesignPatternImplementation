using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Products.ConcreteProducts
{
    public class WindowsTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying a Windows-style TextBox.");
            // Imagine actual Windows UI display logic here
        }
    }
}
