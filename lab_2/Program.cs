using System;

namespace lab_2
{
    public class Program
    {
        private static void MethodSimpleIteration()
        {
            double eps = 0.001;
            double x = 2.0, y = 2.0;

            double alpha = -1.0;
            double beta = 0.5;
            double gamma = 1.0;
            double delta = -1.0;

            int k = 0;
            double x0; double x1 = x;     // x0 = x(k), x1 = x(k+1)
            double y0; double y1 = y;     //y0 = y(k), y1 = y(k+1)
            double modx, mody;

            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("|   k   |    X(k)    |   X(k + 1)   |  |(X(k+1) - X(k))|  |    Y(k)    |   Y(k+1)   | |Y(k+1) - Y(k)| |\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");

            do
            {
                x0 = x1; y0 = y1;
                x1 = x0 + alpha*(2*x0 + y0 - 7) + beta*(x0*y0 - 6);
                y1 = y0 + gamma*(2*x0 + y0 - 7) + delta*(x0*y0 - 6);

                modx = Math.Abs(x1 - x0);
                mody = Math.Abs(y1 - y0);

                Console.WriteLine($"|   {k}   |    {x0}    |   {x1}   |  {modx}  |    {y0}    |   {y1}   | {mody} |\n");
                k++;
            } while ((modx > eps) || (mody > eps));
        }

        private static void NewtonMethod()
        {
            double eps = 0.001;
            double x = 2.0, y = 2.0;

            double alpha = -1.0;
            double beta = 0.5;
            double gamma = 1.0;
            double delta = -1.0;

            int k = 0;
            double x0; double x1 = x;     // x0 = x(k), x1 = x(k+1)
            double y0; double y1 = y;     //y0 = y(k), y1 = y(k+1)
            double modx, mody;

            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("|   k   |    X(k)    |   X(k + 1)   |  |(X(k+1) - X(k))|  |    Y(k)    |   Y(k+1)   | |Y(k+1) - Y(k)| |\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");

            do
            {
                x0 = x1; y0 = y1;
                x1 = x0 - ((x0 * alpha * (2 * x0 + y0 - 7) + beta * (x0 * y0 - 6)) + (-1) * (gamma * (2 * x0 + y0 - 7) + delta * (x0 * y0 - 6))) / (2 * x0 - y0);

                y1 = y0 - ((-y0 * alpha * (2 * x0 + y0 - 7) + beta * (x0 * y0 - 6)) + 2 * (gamma * (2 * x0 + y0 - 7) + delta * (x0 * y0 - 6))) / (2 * x0 - y0);

                modx = Math.Abs(x1 - x0);
                mody = Math.Abs(y1 - y0);

                Console.WriteLine($"|   {k}   |    {x0}    |   {x1}   |  {modx}  |    {y0}    |   {y1}   | {mody} |\n");
                k++;
            } while ((modx > eps) || (mody > eps));
        }

        static void Main(string[] args)
        {
            MethodSimpleIteration();
            NewtonMethod();
        }
    }
}
