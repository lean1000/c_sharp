using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema...");
            Console.Clear();
            Console.WriteLine("Leandro Piai\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            ███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
            ██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
            █████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
            ██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
            ███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
            ╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░██");
            menuExercicios();

        }

        static void menuExercicios()
        {
            Console.WriteLine("\n00 - Sair.");
            Console.WriteLine("01 - O número é positivo, Negativo ou Zero ?");
            Console.WriteLine("02 - Soma, Divisão, Multiplicação e Subitração.");
            Console.WriteLine("03 - Verificação de Aprovação ou Reprova.");
            Console.WriteLine("04 - Celsius para Fahrenheit e vice-versa.");
            Console.WriteLine("05 - Avaliação de filmes de 1 a 5.");
            Console.WriteLine("06 - Qual dos 3 numeros é o maior ?");
            int opcaoEscolidanumero = int.Parse(Console.ReadLine());

            switch (opcaoEscolidanumero)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 01");
                    opcao1();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 02");
                    opcao2();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 03");
                    opcao3();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 04");
                    opcao4();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 05");
                    opcao5();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opição 06");
                    opcao6();
                    Thread.Sleep(3000);
                    Console.Clear();
                    menuExercicios();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("\nSaindo...");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\n Você digitou uma opção invalida");
                    break;
            }
        }

       static void opcao1()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
        static void opcao2()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            double divisao = (double)num1 / num2; // Conversão para double para obter resultado decimal

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");

            if (num2 != 0)
            {
                Console.WriteLine($"Divisão: {divisao}");
            }
            else
            {
                Console.WriteLine("Divisão: não é possível dividir por zero.");
            }
        }
        static void opcao3()
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("Recuperação");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
        }
        static void opcao4()
        {
            Console.WriteLine("Escolha a conversão que deseja fazer:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.Write("Digite a opção (1 ou 2): ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} °C equivale a {fahrenheit} °F");
            }
            else if (opcao == 2)
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit} °F equivale a {celsius} °C");
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
            }
        }
        static void opcao5()
        {
            Console.Write("Avalie o filme de 1 a 5: ");
            int avaliacao = Convert.ToInt32(Console.ReadLine());

            switch (avaliacao)
            {
                case 1:
                    Console.WriteLine("Péssimo");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Avaliação inválida. Por favor, insira um número entre 1 e 5.");
                    break;
            }
        }
        static void opcao6()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maior;

            if (num1 >= num2 && num1 >= num3)
            {
                maior = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maior = num2;
            }
            else
            {
                maior = num3;
            }

            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}
