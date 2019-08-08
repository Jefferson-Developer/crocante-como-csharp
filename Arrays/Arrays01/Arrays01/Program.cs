using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("<----Vetor---->\n ");
            Console.ForegroundColor = ConsoleColor.Red;
            int[] valor = new int[50];
            valor[0] = 25;
            valor[25] = 25;

            int x;
            for (x=0;x<5;x++){
                Console.Write("Digite um valor: ");
                valor[x] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();

        }
    }
}
