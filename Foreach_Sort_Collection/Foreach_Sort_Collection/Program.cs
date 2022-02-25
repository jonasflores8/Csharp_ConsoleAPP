using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Sort_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********************Exemplo de Array em ordem*********
            string[] nome = new string[3];
            nome[0] = "Jonas1";
            nome[1] = "Matheus";
            nome[2] = "Ana";

            Array.Sort(nome); // Ordena os nomes
            foreach(string a in nome)
            {
                Console.WriteLine(a);
            }

            if(Array.Exists(nome, e => e == "Jonas1"))
            {
                Console.WriteLine("Existe no meu Array");//Metodo estático e fazer a sintaxe nele
            }
            int size = nome.Length; // tamanho do array

            // Tambem posso identificar parte do meu Array e se for diferente de -1 executa o bloco
            if (Array.Exists(nome, e => e.IndexOf("Jon") != -1))
            {
                Console.WriteLine("Temos uma parte de Jonas1");
            }
            else
                Console.WriteLine("Não existe");

            //********************Collection*********************

            List<string> nome2 = new List<string>();
            nome2.Add("Jonas");
            nome2.Add("Wesley");
            nome2.Add("Lucas");
            nome2.Add("Fernando");
            nome2.Add("Ana");

            foreach (string dys in nome2)
            {
                Console.WriteLine(dys);
            }

            int size_list= nome2.Count;
            Console.WriteLine(size_list);

            nome2.ToArray(); // converte collection para array

            //**************Posso testar tambem ***********

            if (nome2.Exists(e => e == "Pedro"))// Sintaxe para usar o Exist do List
            {
                Console.WriteLine("Sim");
            }
            else
                Console.WriteLine("Não");

            Console.Read();
        }
    }
}
