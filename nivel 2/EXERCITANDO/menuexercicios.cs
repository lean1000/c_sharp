using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class menuexercicios
    {
        public void menuExercicios()
        {
            Console.WriteLine("\n00 - Sair.");
            Console.WriteLine("01 - O número é positivo, Negativo ou Zero ?");
            Console.WriteLine("02 - Soma, Divisão, Multiplicação e Subitração.");
            Console.WriteLine("03 - Verificação de Aprovação ou Reprova.");
            Console.WriteLine("04 - Celsius para Fahrenheit e vice-versa.");
            Console.WriteLine("05 - Avaliação de filmes de 1 a 5.");
            Console.WriteLine("06 - Qual dos 3 numeros é o maior ?");
            Console.WriteLine("Exercicios Extra");
            Console.WriteLine("07 - Nome de tras pra frente.");
            Console.WriteLine("08 - Reais em outras moedas.");
            int opcaoEscolidanumero = int.Parse(Console.ReadLine());

            switch (opcaoEscolidanumero)
            {

                case 1:

                    Exercicio1 exercicio1 = new Exercicio1();
                    exercicio1.opcao1();
                    break;

                case 2:

                    Exercicio2 exercicio2 = new Exercicio2();
                    exercicio2.opcao2();
                    break;

                case 3:

                    Exercicio3 exercicio3 = new Exercicio3();
                    exercicio3.opcao3();
                    break;

                case 4:

                    Exercicio4 exercicio4 = new Exercicio4();
                    exercicio4.opcao4();
                    break;

                case 5:

                    Exercicio5 exercicio5 = new Exercicio5();
                    exercicio5.opcao5();
                    break;

                case 6:

                    Exercicio6 exercicio6 = new Exercicio6();
                    exercicio6.opcao6();
                    break;

                case 7:

                    extra1 extra1 = new extra1();
                    extra1.Extra1();
                    break;

                case 8:

                    extra2 extra2 = new extra2();
                    extra2.Extra2();
                    break;

                case 0:

                    Console.WriteLine("\nSaindo...");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\n Você digitou uma opção invalida");
                    break;
            }
        }
    }
}    
