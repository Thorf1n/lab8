namespace Factory
{
    internal class Programm
    {
        static void Main()
        {
            Console.WriteLine("Enter the type of chart (Line/Bar/Pie): ");
            string chartType = Console.ReadLine().ToLower();

            GraphFactory factory;

            switch (chartType)
            {
                case "line":
                    factory = new LineChartFactory();
                    break;

                case "bar":
                    factory = new BarChartFactory();
                    break;

                case "pie":
                    factory = new PieChartFactory();
                    break;

                default:
                    Console.WriteLine("Invalid chart type.");
                    return;
            }

            Chart chart = factory.CreateChart();

            if (chart is IDataChart dataChart)
            {
                dataChart.GetData();
            }

            chart.Draw();
        }
    }
}