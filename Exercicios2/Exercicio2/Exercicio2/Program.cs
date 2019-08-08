using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, pote;
            Console.Write("Digite o Primeiro Numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Segundo numero :");
            b = Convert.ToInt32(Console.ReadLine());
            
            if (b>a)
            {
                pote = a;
                a = b;
                b = pote;
            }


            for (int l=a; l>=b;l--)
            {

                if (l%2==1)
                {
                    Console.WriteLine(l);
                }
            }

            Console.ReadKey();
        }
    }
}
