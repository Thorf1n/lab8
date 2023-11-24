

namespace AbstractFactory
{
    internal class Abstract
    {
        public interface IScreen
        {
            void Display();
        }

        public interface IProcessor
        {
            void PerformOperation();
        }

        public interface ICamera
        {
            void CapturePhoto();
        }

        public class PhoneScreen : IScreen
        {
            public void Display()
            {
                Console.WriteLine("Phone Screen displaying");
            }
        }

        public class TabletScreen : IScreen
        {
            public void Display()
            {
                Console.WriteLine("Tablet Screen displaying");
            }
        }

        public class LaptopScreen : IScreen
        {
            public void Display()
            {
                Console.WriteLine("Laptop Screen displaying");
            }
        }

        public class PhoneProcessor : IProcessor
        {
            public void PerformOperation()
            {
                Console.WriteLine("Phone Processor performing operation");
            }
        }

        public class TabletProcessor : IProcessor
        {
            public void PerformOperation()
            {
                Console.WriteLine("Tablet Processor performing operation");
            }
        }

        public class LaptopProcessor : IProcessor
        {
            public void PerformOperation()
            {
                Console.WriteLine("Laptop Processor performing operation");
            }
        }

        public class PhoneCamera : ICamera
        {
            public void CapturePhoto()
            {
                Console.WriteLine("Phone Camera capturing photo");
            }
        }

        public class TabletCamera : ICamera
        {
            public void CapturePhoto()
            {
                Console.WriteLine("Tablet Camera capturing photo");
            }
        }

        public class LaptopCamera : ICamera
        {
            public void CapturePhoto()
            {
                Console.WriteLine("Laptop Camera capturing photo");
            }
        }

        public interface IProductFactory
        {
            IScreen CreateScreen();
            IProcessor CreateProcessor();
            ICamera CreateCamera();
        }

        public class PhoneFactory : IProductFactory
        {
            public IScreen CreateScreen()
            {
                return new PhoneScreen();
            }

            public IProcessor CreateProcessor()
            {
                return new PhoneProcessor();
            }

            public ICamera CreateCamera()
            {
                return new PhoneCamera();
            }
        }

        public class TabletFactory : IProductFactory
        {
            public IScreen CreateScreen()
            {
                return new TabletScreen();
            }

            public IProcessor CreateProcessor()
            {
                return new TabletProcessor();
            }

            public ICamera CreateCamera()
            {
                return new TabletCamera();
            }
        }

        public class LaptopFactory : IProductFactory
        {
            public IScreen CreateScreen()
            {
                return new LaptopScreen();
            }

            public IProcessor CreateProcessor()
            {
                return new LaptopProcessor();
            }

            public ICamera CreateCamera()
            {
                return new LaptopCamera();
            }
        }

        public class ProductAssembler
        {
            private IProductFactory productFactory;

            public ProductAssembler(IProductFactory factory)
            {
                productFactory = factory;
            }

            public void AssembleProduct()
            {
                IScreen screen = productFactory.CreateScreen();
                IProcessor processor = productFactory.CreateProcessor();
                ICamera camera = productFactory.CreateCamera();

                Console.WriteLine("Assembling product with the following components:");
                screen.Display();
                processor.PerformOperation();
                camera.CapturePhoto();
            }
        }

    }
}
