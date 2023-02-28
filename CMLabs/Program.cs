using System; 

namespace CMLab1_2 
{
    public class Program
    {
        public double F(double x)
        {
            double y;
            y = 3 * Math.Cos(2 * x) - x + 0.25;
            return y;
        }

        public double derivativeF(double x)
        {
            double y;
            y = -6 * Math.Sin(2 * x) - 1;
            return y;
        }
        public void SimpleImplicationsMethod()
        {
            int n = 0;
            double x = 2.5;
            double c = -0.1;
            double eps = 0.001;
            double d = 0.01;
            double xn, xnp1;
            do
            {
                xn = x;
                xnp1 = x + c *
            } while (true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}