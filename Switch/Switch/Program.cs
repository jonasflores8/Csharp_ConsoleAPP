using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {   
        static void Main(string[] args)
        {
            float res;
            Console.WriteLine("Digite o 1ºNumero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2ºNumero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operção que deseja fazer:");
            string operacao = (Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine(res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine(res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine(res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("ERROR 404");
                    break;
            }
            Console.ReadLine();
        }
    }
}
