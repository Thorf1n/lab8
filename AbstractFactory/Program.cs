using static AbstractFactory.Abstract;

namespace AbstractFactory 
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a product type (Phone/Tablet/Laptop): ");
            string productType = Console.ReadLine().ToLower();

            IProductFactory factory;

            switch (productType)
            {
                case "phone":
                    factory = new PhoneFactory();
                    break;

                case "tablet":
                    factory = new TabletFactory();
                    break;

                case "laptop":
                    factory = new LaptopFactory();
                    break;

                default:
                    Console.WriteLine("Invalid product type.");
                    return;
            }

            ProductAssembler assembler = new ProductAssembler(factory);
            assembler.AssembleProduct();
        }
    }
}
