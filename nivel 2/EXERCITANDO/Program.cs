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
            cabecalho cabecalho = new cabecalho();
            cabecalho.cAbecalho();

            menuexercicios menuexercicios = new menuexercicios();
            menuexercicios.menuExercicios();
        }
    }
}
