using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class extra2
    {
        public void Extra2()
        {
                double taxaDolar = 5.50; 
                double taxaEuro = 6.20;  
                double taxaLibra = 7.30; 

                Console.Write("Digite o valor em reais (R$): ");
                double valorReais = Convert.ToDouble(Console.ReadLine());

                double valorDolar = valorReais / taxaDolar;
                double valorEuro = valorReais / taxaEuro;
                double valorLibra = valorReais / taxaLibra;

                Console.WriteLine($"Valor em dólares: ${valorDolar:F2}");
                Console.WriteLine($"Valor em euros: €{valorEuro:F2}");
                Console.WriteLine($"Valor em libras esterlinas: £{valorLibra:F2}");

        }
    }
}
