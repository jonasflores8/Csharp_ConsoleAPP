using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        enum op { Ler = 1, Calcular, Mostrar }; //Cada opção armazena um valor numérico
        double a, b, c;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma das opções abaixo");
            Console.WriteLine("\nLer\nCalcular\nMostrar");
            int index = int.Parse(Console.ReadLine());//Crio uma variável de indice  

            op Selectop = (op)index;//Crio uma opção e converto o valar de indice para opão da "enum op"
            //Console.WriteLine(Selectop);

            switch (Selectop)
            {
                case op.Ler:
                    Console.WriteLine("Lendo códogo....");
                    break;
                case op.Calcular:
                    Console.WriteLine("Calculando....");
                    break;
                case op.Mostrar:
                    Console.WriteLine("Código");
                    break;
            }
            Console.ReadLine();
        }
    }
}