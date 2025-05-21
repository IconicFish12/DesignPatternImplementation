using ObserverProject;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter initial stock: ");
        int initialStock = int.Parse(Console.ReadLine());

        ProductStock product = new ProductStock(name, initialStock);

        // Tambahkan observer
        product.Attach(new AdminObserver());
        product.Attach(new LoggerObserver());
        product.Attach(new AutoReorderObserver());

        // Input loop
        while (true)
        {
            Console.Write("\nEnter new stock value (or 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            if (int.TryParse(input, out int newStock))
            {
                product.SetStock(newStock);
            }
            else
            {
                Console.WriteLine("[ERROR] Invalid number. Try again.");
            }
        }

        Console.WriteLine("Program ended.");
    }
}