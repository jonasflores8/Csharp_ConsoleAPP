using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_2
{
    class Program
    {
        enum verificar {Ler=1, Calcular, Mostrar};

        static void Main(string[] args)
        {
            Console.WriteLine("***Escolha o que deseja fazer***");
            Console.WriteLine("[1]Ler\n[2]Calcular\n[3]Mostrar");
            int opcao = int.Parse(Console.ReadLine());

            verificar Selop = (verificar)opcao;

            switch (Selop) 
            {
                case verificar.Ler:
                    Console.Write("Digite seu nome:");
                    string nome = Console.ReadLine();
                    Console.Write("Sua idade:");
                    int idade = int.Parse(Console.ReadLine());
                    break;
                case verificar.Calcular:
                    float res;
                    Console.WriteLine("******CALCULADORA******");
                    Console.Write("Digite um valor:");
                    int V1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor:");
                    int V2 = int.Parse(Console.ReadLine());
                    Console.Write("Basta digitar [+] [-] [*] ou [/] para escolher a operação:");
                    string op = Console.ReadLine();

                    switch (op)
                    {
                        case "+":
                            res = V1 + V2;
                            Console.Write("\nResultado da operação:");
                            Console.WriteLine(res);
                            break;
                        case "-":
                            res = V1 - V2;
                            Console.Write("\nResultado da operação:");
                            Console.WriteLine(res);
                            break;
                        case "*":
                            res = V1 * V2;
                            Console.Write("\nResultado da operação:");
                            Console.WriteLine(res);
                            break;
                        case "/":
                            res = V1 / V2;
                            Console.Write("\nResultado da operação:");
                            Console.WriteLine(res);
                            break;
                        default:
                            Console.WriteLine("Não foi passível efetuar o cálculo");
                            break;
                    }
                    break;
                case verificar.Mostrar:
                    Console.WriteLine("Parabens você é bom meu chapa");
                    break;
            }
            Console.ReadLine();
        }
    }
}
