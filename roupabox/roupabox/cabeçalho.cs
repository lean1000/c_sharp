using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class cabeçalho
    {
        public void cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Leandro Piai Barreto");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==========================================");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================");
            Console.ResetColor();
        }
    }
}
