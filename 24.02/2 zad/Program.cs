using System;

namespace _2_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете двуично число: ");
            string chislo = Console.ReadLine();
            int chislo10 = Convert.ToInt32(chislo, 2);
            Console.WriteLine("Въведете двуично число: ");
            string chislo2 = Console.ReadLine();
            int chislo210 = Convert.ToInt32(chislo2, 2);
            int sum = chislo10 + chislo210;
            string sum2 = Convert.ToString(sum, 2);
            Console.WriteLine(sum2);
        }
    }
}
