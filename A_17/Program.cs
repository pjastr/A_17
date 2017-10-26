using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę w systemie szesnastkowym");
            string liczba16 = Console.ReadLine();
            int liczba10 = int.Parse(liczba16, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Liczba w systemie dziesiętnym: {0}", liczba10);
            Console.ReadKey();
        }
    }
}
