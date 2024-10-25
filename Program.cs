using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemelyazonosito
{
    internal class Program
    {
        static void szemelyazonosito()
        {
            Console.WriteLine("Adja meg a személyazonosító első 10 számát");
            var szemazon = Console.ReadLine();
            string szulsorszam = szemazon.Substring(7, 3);

            if (szemazon[0] % 2 == 0)
            {
                Console.WriteLine("A személy nő");
            }
            else
            {
                Console.WriteLine("A személy férfi");
            }
            Console.WriteLine($"A születési sorszám: {szulsorszam}");

        }
        static void Main(string[] args)
        {
            szemelyazonosito();
        }
    }
}
