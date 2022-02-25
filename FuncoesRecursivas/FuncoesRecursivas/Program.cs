using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace FuncoesRecursivas
{
    class Program
    {
        private static void LerArquivo(string nameArq)
        {
            using (StreamReader arquivo = File.OpenText(nameArq))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public static void tabuada(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }
        }

        static void Main(string[] args)
        {
            Repeat:
            Console.Write("Digite um valor:");
            int n1 = int.Parse(Console.ReadLine());

            tabuada(n1);
            Console.WriteLine("====================================================================");
            LerArquivo(@"C:\Users\jonas\OneDrive\Área de Trabalho\Fatec\Links da fatec.txt");

            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            goto Repeat;
            Console.Read();
        }
    }
}
