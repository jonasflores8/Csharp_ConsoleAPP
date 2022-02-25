using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"Jonas","Flores","da","Silva"};

            foreach(string nome in palavras) //Para cada palavra no Array palavras, repita o bloco de códigos
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
        }
    }
}
