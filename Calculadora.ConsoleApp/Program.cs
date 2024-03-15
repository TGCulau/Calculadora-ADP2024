using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static string opm = "";
        static int qdn;
        static string opsm = "";
        static int aux = 0;
        static decimal aux2 = 0;
        static decimal cont = 0;
        static decimal aux3 = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            while (true)
            {
                while (opm != "5")
                {
                    Menu();
                    switch (opm)
                    {
                        case "1":
                            Caso1();
                            break;

                        case "2":
                            Caso2();
                            break;

                        case "3":
                            Caso3();
                            break;

                        case "4":
                            Caso4();
                            break;

                        case "5":
                            Exit();
                            break;
                    }
                }
                break;
            }  
        }


        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("############################################################################");
            Console.WriteLine("###                                                                      ###");
            Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
            Console.WriteLine("### 1. Soma                                                              ###");
            Console.WriteLine("### 2. Subtração                                                         ###");
            Console.WriteLine("### 3. Divisão                                                           ###");
            Console.WriteLine("### 4. Multiplicação                                                     ###");
            Console.WriteLine("### 5. Sair                                                              ###");
            Console.WriteLine("###                                                                      ###");
            Console.WriteLine("############################################################################");
            Console.Write("\nDigite sua opção: ");
            opm = Console.ReadLine();

                if (opm != "1" && opm != "2" && opm != "3" && opm != "4" && opm != "5")
                {
                    Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 a 5. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                }
        }

        private static void Caso1()
        {
            while (true) 
            {
                Console.Clear();
                aux = 0;
                Console.WriteLine("############################################################################");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
                Console.WriteLine("###                                 Soma                                 ###");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("############################################################################");
                Console.Write("\nQuantos numeros irá somar? ");
                qdn = Convert.ToInt32(Console.ReadLine());

                if (qdn == 0 || qdn == 1)
                {
                    Console.WriteLine("\nÉ necessário pelo menos 2 numeros para haver uma soma. Por favor, corrija a quantidade de numeros e tente novamente. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }

                while (aux < qdn)
                {
                    aux++;
                    Console.Write($"\nDigite o valor da {aux}ª conta: ");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    cont = aux2 + cont;
                }

                Console.WriteLine($"\nO total somado foi de {cont}. \n\nPrecione qualquer tecla para continuar.\n");
                Console.ReadLine();
                break;
            }
        }

        private static void Caso2()
        {
            while (true)
            {
                Console.Clear();
                aux = 0;
                aux3 = 0;
                cont = 0;
                Console.WriteLine("############################################################################");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
                Console.WriteLine("###                               Subtração                              ###");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("############################################################################");
                Console.Write("\nQuantos numeros irá subtrair? ");
                qdn = Convert.ToInt32(Console.ReadLine());

                if (qdn == 0 || qdn == 1)
                {
                    Console.WriteLine("\nÉ necessário pelo menos 2 numeros para haver uma subtração. Por favor, corrija a quantidade de numeros e tente novamente. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }

                while (aux < qdn)
                {
                    aux++;
                    Console.Write($"\nDigite o valor da {aux}ª conta: ");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    cont = cont - aux2;
                    while (aux == 1)
                    {
                        aux++;
                        Console.Write($"\nDigite o valor da {aux}ª conta: ");
                        aux3 = Convert.ToDecimal(Console.ReadLine());
                        cont = aux2 - aux3;
                    }
                }

                Console.WriteLine($"\nO total subtraido foi de {cont}. \n\nPrecione qualquer tecla para continuar.\n");
                Console.ReadLine();
                break;
            }
            

        }

        private static void Caso3()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("############################################################################");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
                Console.WriteLine("###                                Divisão                               ###");
                Console.WriteLine("###            Somente dois numeros podem se dividir entre si            ###");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("############################################################################");
                Console.Write("\nDigite o valor do dividendo: ");
                aux2 = Convert.ToDecimal(Console.ReadLine());

                if (aux2 == 0)
                {
                    Console.WriteLine("\nNão é possivel dividir um numero por zero, por favor escolha outro numero. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Write("\nDigite o valor do divisor: ");
                aux3 = Convert.ToDecimal(Console.ReadLine());

                if (aux3 == 0)
                {
                    Console.WriteLine("\nNão é possivel dividir um numero por zero, por favor escolha outro numero. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                cont = aux2 / aux3;
                Console.WriteLine($"\nO total dividido foi de {cont}. \n\nPrecione qualquer tecla para continuar.\n");
                Console.ReadLine();
                break;
            }
        }

        private static void Caso4()
        {
            while(true)
            {
                Console.Clear();
                aux = 0;
                cont = 1;
                Console.WriteLine("############################################################################");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
                Console.WriteLine("###                              Multiplicação                           ###");
                Console.WriteLine("###                                                                      ###");
                Console.WriteLine("############################################################################");
                Console.Write("\nQuantos numeros irá multiplicar? ");
                qdn = Convert.ToInt32(Console.ReadLine());

                if (qdn == 0 || qdn == 1)
                {
                    Console.WriteLine("\nÉ necessário pelo menos 2 numeros para haver uma multiplicação. Por favor, corrija a quantidade de numeros e tente novamente. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }

                while (aux < qdn)
                {
                    aux++;
                    Console.Write($"\nDigite o valor da {aux}ª conta: ");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    if (aux2 == 0)
                    {
                        Console.WriteLine("\nNão é possivel multiplicar um numero por zero, pois todo numero multiplicado por 0 é igual a 0, por favor escolha outro numero. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    cont = aux2 * cont;
                }

                Console.WriteLine($"\nO total multiplicado foi de {cont}. \n\nPrecione qualquer tecla para continuar.\n");
                Console.ReadLine();
                break;
            }
        }
                
        private static void Exit()
        {
            opm = "5";
            Console.Clear();
            Console.WriteLine("############################################################################");
            Console.WriteLine("###                                                                      ###");
            Console.WriteLine("###       Academia do programador 2024 - Exercício 1 - Calculadora       ###");
            Console.WriteLine("###                                 Saída                                ###");
            Console.WriteLine("###             Até mais. Precione qualquer tecla para sair.             ###");
            Console.WriteLine("###                                                                      ###");
            Console.WriteLine("############################################################################");
            Console.ReadLine();
        }
    }
}