using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exercicio3
    {
        public void opcao3()
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
    }
}
