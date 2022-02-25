using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            MenSag();
            GerarPreco(2, "bexiga");
            GerarPreco(14, "Leite em pó");
            GerarPreco(-26, "Sabão em pó");
            Console.ReadLine();
        }


        static void MenSag()// significa uma função "vazia" sem retornar um valor
        {
            Console.WriteLine("Show de bola, vamos começar\n");
        }

        static void GerarPreco(int preco, string nome)//Pode criar quantos parametros quiser (int idade, string nome, float peso)
        {
            int precoAbs = Math.Abs(preco); // valor absoluto, Ex: -15 => 15
            int valor = precoAbs + (precoAbs * 2); // Esta variável só pode ser acessada na função: (valor);
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Preço: " + valor);
            
        }
    }
}
