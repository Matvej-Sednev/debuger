namespace debuger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double h = 0.05;
            int n = 10;

            if (h <= 0 || n <= 0)
            {
                Console.WriteLine("Недостаточно данных для выполнения задания.");
                return;
            }

            while (x <= 1 + h)
            {
                double y = Math.Pow(3, x);
                double s = 1;
                double log3 = Math.Log(3.0);

                for (int i = 1; i <= n; i++)
                {
                    double slag = Math.Pow(log3, i) / Factorial(i) * Math.Pow(x, i);
                    s += slag;
                }

                Console.WriteLine("| {0}\t| {1}\t| {2}\t|\n", Math.Round(x, 4), Math.Round(y, 4), Math.Round(s, 4));
                x += h;
            }
        }

        static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            double result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }

    }
    
}
