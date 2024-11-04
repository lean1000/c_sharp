using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio4
    {
        public void opcao4()
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
    }
}
