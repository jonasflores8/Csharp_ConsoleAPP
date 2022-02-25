using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teste_de_func
{
    class Program
    {
        //***********************Função ler arquivo****************************************
        private static void lerArquivo(string nameArq)
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
        //*********************Função tabuada*****************************************
        public static void tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }
        //******************************Função de Leitura******************************
        public static int lerNumero()
        {
            Console.Write("\nDigite um número:");
            int n = int.Parse(Console.ReadLine());

            return n;
        }
        //=============================Programa Principal===============================
        static void Main(string[] args)
        {
            Menu:
            Console.Clear();

            Console.Write("[1]Ler Arquivo\n[2]Tabuada\n[3]Sair\nOpcao:");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    lerArquivo(@"C:\Users\jonas\OneDrive\Área de Trabalho\arquivo\Arq1.txt");
                    break;

                case 2:
                    int num = lerNumero();
                    tabuada(num);
                    break;

                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Valor digitado incorreto, tente outra vez");
                    break;
            }

            System.Threading.Thread.Sleep(5000);
            goto Menu;
            Console.Read();

        }

    }
}
