using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, a=0, maior=0;
            while (num <= 5)
            {

                Console.Write("Digite um Numero: ");
                a = int.Parse(Console.ReadLine());
                if (a>=maior)
                {
                    maior = a;
                }

                num = num + 1; //ou num++
            }
            Console.WriteLine(maior);

            Console.ReadKey();
        }
    }
}
