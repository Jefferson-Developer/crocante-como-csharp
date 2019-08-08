using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDecisão
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int ano, idade;
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o ano de Nascimento: ");
            ano = int.Parse(Console.ReadLine());
            idade = 2019 - ano;

            if (idade < 18)
            {
                Console.Write("Você é menor de Idade!");
            }
            else
            {
                Console.Write("Você é maior de Idade!");
            }
            Console.ReadKey();
        }
    }
}
