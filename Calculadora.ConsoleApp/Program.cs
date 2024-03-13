using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        menu:
            string primerionumero = "";
            int opm, qdn;
            int aux = 0;
            decimal aux2 = 0;
            decimal cont = 0;
            decimal aux3 = 0;

        
            Console.Clear();
            Console.WriteLine("Calculadora desafio 1 ----- Escolha uma das opções do menu");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Sair");
            opm = Convert.ToInt32(Console.ReadLine());

            if (opm < 1 || opm > 5)
            {
                Console.WriteLine("Opção inválida, escolha uma opção válida entre 1 a 5, precione qualquer tecla para continuar.");
                Console.ReadLine();
                goto menu;
            }

            else if (opm == 1)
            {
                Console.Clear();
                Console.WriteLine("Quantos numeros irá somar?");
                qdn = Convert.ToInt32(Console.ReadLine());
                while (aux < qdn)
                {
                    aux++;
                    Console.WriteLine($"Digite o valor da {aux} conta");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    cont = aux2 + cont;
                }
                Console.WriteLine("O total somado foi de " + cont);

            retornosoma:
                Console.WriteLine("Deseja retorar ao menu ou sair?");
                Console.WriteLine("1. Menu");
                Console.WriteLine("2. Sair");
                opm = Convert.ToInt32(Console.ReadLine());

                if (opm < 1 || opm > 2)
                {
                    Console.WriteLine("Opção inválida, escolha uma opção válida entre 1 e 2");
                    Console.ReadLine();
                    goto retornosoma;
                }

                else if (opm == 1)
                {
                    goto menu;
                }

                else if (opm == 2)
                {
                    goto exit;
                }
            }

            else if (opm == 2)
            {
                Console.Clear();
                Console.WriteLine("Quantos numeros irá subtrair?");
                qdn = Convert.ToInt32(Console.ReadLine());
                while (aux < qdn)
                {
                    aux++;
                    Console.WriteLine($"Digite o valor da {aux} conta");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    cont = aux2 - cont;
                }
                Console.WriteLine("O total subtraido foi de " + cont);

            retornosub:
                Console.WriteLine("Deseja retorar ao menu ou sair?");
                Console.WriteLine("1. Menu");
                Console.WriteLine("2. Sair");
                opm = Convert.ToInt32(Console.ReadLine());

                if (opm < 1 || opm > 2)
                {
                    Console.WriteLine("Opção inválida, escolha uma opção válida entre 1 e 2");
                    Console.ReadLine();
                    goto retornosub;
                }

                else if (opm == 1)
                {
                    goto menu;
                }

                else if (opm == 2)
                {
                    goto exit;
                }
            }

            else if (opm == 3)
            {
                Console.Clear();
            divisaoi:
                Console.WriteLine("Somente dois numeros podem se dividir entre si");
                Console.WriteLine("Digite o valor do dividendo");
                aux2 = Convert.ToDecimal(Console.ReadLine());
                if(aux2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir um numero por zero, por favor escolha outro numero");
                    goto divisaoi;
                }
                Console.WriteLine("Digite o valor do divisor");
                aux3 = Convert.ToDecimal(Console.ReadLine());
                if (aux3 == 0)
                {
                    Console.WriteLine("Não é possivel dividir um numero por zero, por favor escolha outro numero");
                    goto divisaoi;
                }
                cont = aux2 / aux3;
                Console.WriteLine("O total dividido foi de " + cont);

            retornodivi:
                Console.WriteLine("Deseja retorar ao menu ou sair?");
                Console.WriteLine("1. Menu");
                Console.WriteLine("2. Sair");
                opm = Convert.ToInt32(Console.ReadLine());

                if (opm < 1 || opm > 2)
                {
                    Console.WriteLine("Opção inválida, escolha uma opção válida entre 1 e 2");
                    Console.ReadLine();
                    goto retornodivi;
                }

                else if (opm == 1)
                {
                    goto menu;
                }

                else if (opm == 2)
                {
                    goto exit;
                }
            }

            else if (opm == 4)
            {
                Console.Clear();
                Console.WriteLine("Quantos numeros irá multiplicar?");
                qdn = Convert.ToInt32(Console.ReadLine());
                cont = 1;
                while (aux < qdn)
                {
                    aux++;
                    Console.WriteLine($"Digite o valor da {aux} conta");
                    aux2 = Convert.ToDecimal(Console.ReadLine());
                    cont = aux2 * cont;
                }
                Console.WriteLine("O total multiplicado foi de " + cont);

            retornomulti:
                Console.WriteLine("Deseja retorar ao menu ou sair?");
                Console.WriteLine("1. Menu");
                Console.WriteLine("2. Sair");
                opm = Convert.ToInt32(Console.ReadLine());

                if (opm < 1 || opm > 2)
                {
                    Console.WriteLine("Opção inválida, escolha uma opção válida entre 1 e 2");
                    Console.ReadLine();
                    goto retornomulti;
                }

                else if (opm == 1)
                {
                    goto menu;
                }

                else if (opm == 2)
                {
                    goto exit;
                }
            }

        exit:
            Console.WriteLine("Até mais. Precione qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}