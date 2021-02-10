using System;

namespace _10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko uchenici ima: ");
            int n = int.Parse(Console.ReadLine());
            double obshto;
            double suma = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("vuvedete uspeha: ");
                double u = double.Parse(Console.ReadLine());
                suma = suma + u;
            }
            obshto = suma / n;
            Console.WriteLine("{0:f2}", obshto);
        }
    }
}
