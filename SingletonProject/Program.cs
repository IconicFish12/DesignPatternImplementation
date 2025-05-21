using SingletonProject.Config;
using SingletonProject.ImplementExample;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger1 = new Logger();
        logger1.LogMessage("Application started.");

        DatabaseService dbService1 = new DatabaseService();
        dbService1.Connect();

        string version = ConfigurationManager.Instance.getSettings("ApplicationVersion");
        string AppName = ConfigurationManager.Instance.getSettings("ApplicationName");

        Console.WriteLine($"Applicatio Name {AppName} version {version}");
    }
}