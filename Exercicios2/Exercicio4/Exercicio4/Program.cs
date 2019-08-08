using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, pote;
            Console.Write("Digite um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor:  ");
            b = int.Parse(Console.ReadLine());
            if (b>a)
            {
                pote = a;
                a = b;
                b = pote;
            }
            pote = 0;
            for(int l=a; l >= b; l--)
            {
                if (l % 2 == 1)
                {
                    pote++;
                }
                
            }
            Console.WriteLine("A quantidade de numeros impares é " +pote);
            Console.ReadKey();
        }
    }
}
