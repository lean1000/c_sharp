using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio5
    {
        public void opcao5()
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
    }
}
