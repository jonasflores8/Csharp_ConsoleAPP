using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Functions
{
    class Program2
    {
        static void main() 
        {
            Program.Tabuada(4);
            var pg = new Program();
        }
    }
    class Program
    {

        private static int Soma()
        {
            int a = 10;
            int b = 5;
            int c = a + b;
            return(c);
        }
        
        public static void Tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }

        static void Main(string[] args)
        {
            Menu:
            Console.Write("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            Tabuada(n);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();

            goto Menu;
            Console.Read();
        }
    }
}
