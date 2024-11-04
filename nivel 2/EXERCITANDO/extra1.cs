using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class extra1
    {
        public void Extra1() 
        {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();

                char[] caracteres = nome.ToCharArray();
                Array.Reverse(caracteres);
                string nomeInvertido = new string(caracteres);

                Console.WriteLine("Nome invertido: " + nomeInvertido);

        }
    }
}
