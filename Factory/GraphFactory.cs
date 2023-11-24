

namespace Factory
{
    public abstract class Chart
    {
        public abstract void Draw();
    }

    public interface IDataChart
    {
        void GetData();
    }

    public class LineChart : Chart, IDataChart
    {
        private List<double> data;

        public override void Draw()
        {
            Console.WriteLine("Drawing Line Chart");
            Console.WriteLine("Data: " + string.Join(", ", data));
        }

        public void GetData()
        {
            Console.WriteLine("Enter data for Line Chart (comma-separated values): ");
            string[] input = Console.ReadLine().Split(',');

            data = new List<double>();

            foreach (var value in input)
            {
                if (double.TryParse(value, out double dataPoint))
                {
                    data.Add(dataPoint);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                    GetData();
                    return;
                }
            }
        }
    }

    public class BarChart : Chart, IDataChart
    {
        private List<double> data;

        public override void Draw()
        {
            Console.WriteLine("Drawing Bar Chart");
            Console.WriteLine("Data: " + string.Join(", ", data));

        }

        public void GetData()
        {
            Console.WriteLine("Enter data for Bar Chart (comma-separated values): ");
            string[] input = Console.ReadLine().Split(',');

            data = new List<double>();

            foreach (var value in input)
            {
                if (double.TryParse(value, out double dataPoint))
                {
                    data.Add(dataPoint);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                    GetData();
                    return;
                }
            }
        }
    }

    public class PieChart : Chart, IDataChart
    {
        private List<double> data;

        public override void Draw()
        {
            Console.WriteLine("Drawing Pie Chart");
            Console.WriteLine("Data: " + string.Join(", ", data));

        }

        public void GetData()
        {
            Console.WriteLine("Enter data for Pie Chart (comma-separated values): ");
            string[] input = Console.ReadLine().Split(',');

            data = new List<double>();

            foreach (var value in input)
            {
                if (double.TryParse(value, out double dataPoint))
                {
                    data.Add(dataPoint);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                    GetData();
                    return;
                }
            }
        }
    }

    public abstract class GraphFactory
    {
        public abstract Chart CreateChart();
    }

    public class LineChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new LineChart();
        }
    }

    public class BarChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new BarChart();
        }
    }

    public class PieChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new PieChart();
        }
    }
}
