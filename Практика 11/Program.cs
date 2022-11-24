using System;
namespace ConsoleWhile
{
    class Program
    {
        static void Main()
        {
            double a = 0, e = 0.001, q = 0, s = 0, x = 0.15;
            int n = 0;
            a = x;
            s = a;
            while (Math.Abs(a) > e)
            {
                q = -x * x / (4 * n * n + 1) / (4 * n * n + 8 * n + 5);
                a *= q;
                s += a;
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("Результат");
            Console.WriteLine();
            Console.WriteLine("Сумма s=" + Convert.ToString(s));
            Console.WriteLine("Число членов ряда n=" + Convert.ToString(n));
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}