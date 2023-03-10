using System; 

namespace CMLab1_2 
{
    public class Program
    {
        public static double F(double x)
        {
            double y;
            y = 3 * Math.Cos(2 * x) - x + 0.25;
            return y;
        }

        public static double derivativeF(double x)
        {
            double y;
            y = -6 * Math.Sin(2 * x) - 1;
            return y;
        }

        public static void SimpleImplicationsMethod()
        {
            int n = 0;
            double x = 2.5;
            double c = -0.1;
            double eps = 0.001;
            double d = 0.01;
            double xn, xnp1, mod1, mod2;
            string underline = string.Concat(Enumerable.Repeat("-", 120));

            Console.WriteLine(
                "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    "n", "Xn", "Xn+1", "|Xn - Xn+1|", "     |F(Xn+1)|\n" + underline + "\n"
            );

            do
            {
                xn = x;
                xnp1 = x + c * F(x);
                mod1 = Math.Abs(xn - xnp1);
                mod2 = Math.Abs(F(xnp1));

                x = xnp1;

                Console.WriteLine(
                    "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    n, xn, xnp1, mod1, mod2
                    );
                n++;
            } while ((mod1 > eps) || (mod2 > d));
        }

        public static void NewtonMethod()
        {
            int n = 0;
            double x = 2.5;
            double c = -0.1;
            double eps = 0.001;
            double d = 0.01;
            double xn, xnp1, mod1, mod2;
            string underline = string.Concat(Enumerable.Repeat("-", 120));

            Console.WriteLine(
                "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    "n", "Xn", "Xn+1", "|Xn - Xn+1|", "     |F(Xn+1)|\n" + underline + "\n"
            );

            do
            {
                xn = x;
                xnp1 = x - F(x) / derivativeF(x);
                mod1 = Math.Abs(xnp1 - xn);
                mod2 = Math.Abs(F(xnp1));

                x = xnp1;

                Console.WriteLine(
                    "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    n, xn, xnp1, mod1, mod2
                    );
                n++;
            } while ((mod1 > eps) || (mod2 > d));
        }

        public static void NewtonModificationMethod()
        {
            int n = 0;
            double x = 2.5;
            double c = -0.1;
            double eps = 0.001;
            double d = 0.01;
            double xn, xnp1, mod1, mod2;
            string underline = string.Concat(Enumerable.Repeat("-", 120));

            double x0 = x;

            Console.WriteLine(
                "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    "n", "Xn", "Xn+1", "|Xn - Xn+1|", "     |F(Xn+1)|\n" + underline + "\n"
            );

            do
            {
                xn = x;
                xnp1 = x - F(x) / derivativeF(x0);
                mod1 = Math.Abs(xnp1 - xn);
                mod2 = Math.Abs(F(xnp1));

                x = xnp1;

                Console.WriteLine(
                    "{0, 5}   ||{1, 25}   ||{2, 25}   ||{3, 25}   ||{4, 25}",
                    n, xn, xnp1, mod1, mod2
                    );
                n++;
            } while ((mod1 > eps) || (mod2 > d));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nМетод простых итераций\n");
            SimpleImplicationsMethod();

            Console.WriteLine("\n\n\nМетод Ньютона\n");
            NewtonMethod();

            Console.WriteLine("\n\n\nМодифицированный метод Ньютона\n");
            NewtonModificationMethod();
        }
    }
}



