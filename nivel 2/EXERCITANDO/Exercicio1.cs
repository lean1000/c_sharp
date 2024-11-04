using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio1
    {
        public void opcao1()

        {
            Console.Clear();
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
            Console.Clear();
            Thread.Sleep(3000);
            cabecalho cabecalho = new cabecalho();
            cabecalho.cAbecalho();

            menuexercicios menuexercicios = new menuexercicios();
            menuexercicios.menuExercicios();
        }
    }

}
