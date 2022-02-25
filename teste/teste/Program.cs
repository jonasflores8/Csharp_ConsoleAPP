using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static int a, b, c;
        static double delta, x1, x2, x;

        static void Main(string[] args)
        {
            Console.Write("Coeficiente A:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Coeficiente B:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Coeficiente C:");
            c = int.Parse(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Não é equação de 2ºGrau");
            else 
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                Console.Write("Valor de Delta:");
                Console.WriteLine(delta);

                if(delta > 0)
                {
                    x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                    x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                    Console.Write("Raiz 1:");
                    Console.WriteLine(x1);
                    Console.Write("Raiz 2:");
                    Console.WriteLine(x2);
                }
                else if (delta == 0)
                {
                    x = (-b) / (2 * a);
                    Console.Write("Possui apenas uma raiz:");
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Sem raizes reais");
                }
            }
            
            Console.ReadLine();

        }
    }
}
