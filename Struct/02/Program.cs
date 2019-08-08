using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        public struct Lista
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double media;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Lista[] lista = new Lista[3];

            for (int i = 0; i<3; i++)
            {
                Console.Write("Nome: ");
                lista[i].nome = Console.ReadLine();

                Console.Write("Nota1: ");
                lista[i].nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota2: ");
                lista[i].nota2 = double.Parse(Console.ReadLine());

                
                lista[i].media = (lista[i].nota1 + lista[i].nota2)/2;
            }
            for (int i = 0; i<3; i++)
            {
                Console.Write("\n\n O nome do aluno é " + lista[i].nome + ", a primeira nota é " + lista[i].nota1 + " e a segunda nota " + lista[i].nota2 + " a media ficou " + lista[i].media);
                if (lista[i].media <= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Aluno reprovado! ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" Aluno aprovado! ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            Console.ReadKey();
        }
    }
}
