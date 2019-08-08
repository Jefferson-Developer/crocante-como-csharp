using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 11; x <= 250; x++)
            {
                if(x%2 !=1)
                Console.WriteLine("{0}", x);
            }
            Console.ReadKey();
        }
    }
}
