using FactoryProject.Creators;
using FactoryProject.Creators.Concrete_Creators;
using FactoryProject.Products;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Demonstrating Factory Method Pattern ---");

        // Scenario 1: Create Windows-style UI
        Console.WriteLine("\nClient: Requesting Windows UI elements...");
        UIFactory windowsFactory = new WindowsUIFactory();
        IButton windowsButton = windowsFactory.CreateButton();
        ITextBox windowsTextBox = windowsFactory.CreateTextBox();

        windowsButton.Render();
        windowsTextBox.Display();

        // Also demonstrate the BuildUIElementSet method
        windowsFactory.BuildUIElementSet();


        // Scenario 2: Create Mac-style UI
        Console.WriteLine("\nClient: Requesting Mac UI elements...");
        UIFactory macFactory = new MacUIFactory();
        IButton macButton = macFactory.CreateButton();
        ITextBox macTextBox = macFactory.CreateTextBox();

        macButton.Render();
        macTextBox.Display();

        // Also demonstrate the BuildUIElementSet method
        macFactory.BuildUIElementSet();


        Console.WriteLine("\n--- Factory Method Demonstration Complete ---");
        Console.ReadKey();
    }
}
