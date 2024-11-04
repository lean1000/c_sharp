using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio2
    {
        public void opcao2()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            double divisao = (double)num1 / num2;

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
    }
}
