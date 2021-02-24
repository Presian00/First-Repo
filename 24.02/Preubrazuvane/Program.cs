using System;

namespace Preubrazuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            //преубразувайте десетично в двуично
            Console.WriteLine("Въведете десетично число: ");
            int chislo = int.Parse(Console.ReadLine());
            string chislo2 = Convert.ToString(chislo, 2);
            string chislo16 = Convert.ToString(chislo, 16);
            Console.WriteLine("Десетичното е: " + chislo);
            Console.WriteLine("Двуичното е: " + chislo2);
            Console.WriteLine("Шеснайсетичното е:" + chislo16);
        }
    }
}
