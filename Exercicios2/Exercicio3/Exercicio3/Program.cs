using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Digite um Numero: ");
            a = int.Parse(Console.ReadLine());
            for (int l=0; l<=10;l++)
            {
                Console.WriteLine(a + "*" +l+ "=" +a*l);
            }
            Console.ReadKey();
        }
    }
}
