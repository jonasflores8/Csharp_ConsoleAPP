using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = {" Jonas ", "Flores ", "da ", " Silva "};

            for (int num = 0; num < nome.Length; num++)
            {
                Console.Write(nome[num]);
            }
            Console.WriteLine("\n==========================");
            for (int num2 = 3; num2 >= 0; num2--)
            {
                Console.Write(nome[num2]);
            }

            Console.ReadLine();
        }
    }
}
