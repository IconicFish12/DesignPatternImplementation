using FactoryProject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Creators
{
    public abstract class UIFactory
    {
        // The "Factory Method" for IButton
        public abstract IButton CreateButton();

        // Another "Factory Method" for ITextBox
        public abstract ITextBox CreateTextBox();

        // Optional: A method that uses the factory methods.
        // This demonstrates how the factory methods are utilized internally
        // by the creator to produce products, without knowing concrete types.
        public void BuildUIElementSet()
        {
            IButton button = CreateButton();
            ITextBox textBox = CreateTextBox();

            Console.WriteLine("\n--- Building UI Element Set ---");
            button.Render();
            textBox.Display();
            Console.WriteLine("-------------------------------\n");
        }
    }
}
