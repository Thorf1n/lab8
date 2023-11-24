using static ImportSystem.Prototype;

namespace ImportSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose source data format (CSV/XML/JSON): ");
            string sourceFormat = Console.ReadLine().ToUpper();

            Console.WriteLine("Choose target data format (CSV/XML/JSON): ");
            string targetFormat = Console.ReadLine().ToUpper();

            IDataTemplate sourceTemplate;
            switch (sourceFormat)
            {
                case "CSV":
                    sourceTemplate = new CsvDataTemplate();
                    break;
                case "XML":
                    sourceTemplate = new XmlDataTemplate();
                    break;
                case "JSON":
                    sourceTemplate = new JsonDataTemplate();
                    break;
                default:
                    Console.WriteLine("Invalid source data format.");
                    return;
            }

            sourceTemplate.SetData("Name", "Max Schwarz");
            sourceTemplate.SetData("Age", 27);
            sourceTemplate.SetData("City", "Helsinki");

            IDataAdapter adapter = new DataAdapter();
            IDataTemplate targetTemplate = adapter.Convert(sourceTemplate);

            Console.WriteLine($"Source Data ({sourceFormat}):");
            Console.WriteLine($"Name: {sourceTemplate.GetData("Name")}");
            Console.WriteLine($"Age: {sourceTemplate.GetData("Age")}");
            Console.WriteLine($"City: {sourceTemplate.GetData("City")}");

            Console.WriteLine($"Target Data ({targetFormat}):");
            Console.WriteLine($"Name: {targetTemplate.GetData("Name")}");
            Console.WriteLine($"Age: {targetTemplate.GetData("Age")}");
            Console.WriteLine($"City: {targetTemplate.GetData("City")}");
        }
    }
}