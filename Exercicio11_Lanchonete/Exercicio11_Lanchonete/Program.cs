using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao,lanches, bebidas;
            do
            {
                Console.Clear();
                Console.WriteLine("* * * Lanchonete * * *");

                Console.WriteLine("\n1. Lanches ");
                Console.WriteLine("2. Bebidas ");
                Console.WriteLine("3. Conta ");
                Console.WriteLine("0. Sair ");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) //inicio do switch
                {
                    case 1:
                        int opcaoLanches;
                        double totalLanches;
                        Console.Clear();
                        Console.WriteLine("* Lanches *");
                        Console.WriteLine("\n1. Hamburguer 5,00");
                        Console.WriteLine("2. X-Burguer 7,00");
                        Console.WriteLine("3. X-Egg 10,00");
                        Console.WriteLine("4. Bauru 3,00");
                        Console.WriteLine("5. Pizza Hot 5,00");
                        Console.WriteLine("6. Coxinhas 2,00");
                        Console.WriteLine("0. Sair");
                        opcaoLanches = int.Parse(Console.ReadLine());
                        switch (opcaoLanches)
                        {
                            case 1:
                                Console.WriteLine("Você selecionou Hamburguer!");
                                totalLanches = 5.00;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                            case 2:
                                Console.WriteLine("Você selecionou X-Burguer!");
                                totalLanches = 7.00;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                            case 3:
                                Console.WriteLine("Você selecionou X-Egg!");
                                totalLanches = 10;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                            case 4:
                                Console.WriteLine("Você selecionou Bauru!");
                                totalLanches = 3.00;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                            case 5:
                                Console.WriteLine("Você selecionou Pizza Hot!");
                                totalLanches = 5.00;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                            case 6:
                                Console.WriteLine("Você selecionou coxinha!");
                                totalLanches = 2.00;
                                Console.Write("Você gastou até agora: R$ " + totalLanches);
                                break;
                        }

                        break;

                        switch (lanches)
                        {
                            case 1:
                                break;
                        }
                    case 2:

                        Console.WriteLine("\n* Bebidas * ");
                        Console.WriteLine("\n1. Coca-Cola 5,00");
                        Console.WriteLine("2. Guaraná 4,00");
                        Console.WriteLine("3. Tubaina 3,00");
                        Console.WriteLine("4. Soda Limonada 4,00");
                        Console.WriteLine("5. Fanta 5,00");
                        Console.WriteLine("0. Voltar");
                        break;
                        switch (bebidas)
                        {
                            case 2:
                                break;
                        }
                        switch (bebidas)
                        {

                            case 1:
                                break;
                        }

                    case 3:
                        Console.WriteLine("\n* Conta *");

                        break;

                }

                Console.ReadKey();
            } while (opcao != 0);
        }   
    }
}
