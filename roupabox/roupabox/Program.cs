using roupabox;
using System;

namespace RoupaBox

{

    public class Program

    {

        public static void Main(string[] args)

        {

            cabeçalho cab = new cabeçalho();

            cab.cabecalho();

            Menu menu = new Menu();

            menu.ExibirMenu();

        }

    }

}