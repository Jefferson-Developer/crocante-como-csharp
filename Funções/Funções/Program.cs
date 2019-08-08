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
            int ano;
            string nomePessoa;
            void mostrarNome(string nome)
            {
                Console.WriteLine("Nome: {0}", nome);
            }

            int calcularIdade(int anoNasc)
            {
                return 2019 - anoNasc;
            }

            Console.WriteLine("Digite seu nome: ");
            nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento: ");
            ano =int.Parse(Console.ReadLine());

            mostrarNome(nomePessoa);
            Console.WriteLine("Idade: {0}",calcularIdade(2000));

            Console.ReadKey();
        }
    }
}
