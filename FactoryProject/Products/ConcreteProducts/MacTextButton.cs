using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Products.ConcreteProducts
{
    public class MacTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying a Mac-style TextBox.");
            // Imagine actual Mac UI display logic here
        }
    }
}
