using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    class Program
    {
        // Criei a estrutura de uma data, com seus componentes.
        public struct Data
        {
            public int Dia;
            public int Mes;
            public int Ano;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Data dia;
            Console.Write("Digite um dia: ");
            dia.Dia = int.Parse(Console.ReadLine());

            Data mes;
            Console.Write("Digite um mês: ");
            mes.Mes = int.Parse(Console.ReadLine());

            Data ano;
            Console.Write("Digite um ano: ");
            ano.Ano = int.Parse(Console.ReadLine());

            if (dia.Dia > 0 && dia.Dia < 32)
            {
                Console.Write("\n O dia inserido é válido!");
            } else
            {
                Console.Write("\n O dia inserido não é válido.");
            }

            if (mes.Mes > 0 && mes.Mes < 13)
            {
                Console.Write("\n\n e o mês inserido é válido! ");
            }
            else
            {
                Console.Write("\n\n e o mês inserido não é válido. ");
            }

            if (ano.Ano > 0)
            {
                Console.Write("\n\n O ano inserido é válido!");
            }

            Console.WriteLine("\n\n" + dia.Dia + "/" + mes.Mes + "/" + ano.Ano);

            Console.ReadKey();
            
        }

    }
}
