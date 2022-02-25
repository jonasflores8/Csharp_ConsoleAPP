using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <=11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if(idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é adolescente");           
            }
            else if(idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é Adulto");
            }
            else
            {
                Console.WriteLine("Você é Idoso");
            }

            Console.WriteLine(nome);
            Console.WriteLine(idade);


            Console.ReadLine();
        }
    }
}
