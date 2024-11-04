using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio6
    {
        public void opcao6()
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
