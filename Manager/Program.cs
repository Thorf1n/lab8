namespace Manager
{
    internal class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            while (true)
            {
                Console.WriteLine("\n1. Set Configuration");
                Console.WriteLine("2. Get Configuration");
                Console.WriteLine("3. Display Configurations");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter configuration key: ");
                        string key = Console.ReadLine();
                        Console.Write("Enter configuration value: ");
                        string value = Console.ReadLine();
                        configManager.SetConfiguration(key, value);
                        Console.WriteLine("Configuration set successfully.");
                        break;

                    case "2":
                        Console.Write("Enter configuration key: ");
                        string getKey = Console.ReadLine();
                        string getValue = configManager.GetConfiguration(getKey);
                        Console.WriteLine($"Configuration value: {getValue ?? "Key not found"}");
                        break;

                    case "3":
                        configManager.DisplayConfigurations();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}