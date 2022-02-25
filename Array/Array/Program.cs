using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[5] {"God of War", "Tomb Raider", "FIFA", "Doom", "Sonic"};
            int[] numero = { 10, 20, 30, 40, 50 };

            produto[2] = "SplinterSell";
            Console.WriteLine(produto[2]);
            Console.WriteLine(numero[3]);

            Console.ReadLine();
        }
    }
}
