using Roupabox;
using System;
using System.Collections.Generic;

namespace RoupaBox
{
    internal class Produtos
    {
        private List<ProdutoCad> listaProdutos = new List<ProdutoCad>();

        public void CadProdutos()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos");

            Console.WriteLine("\nDigite a descrição do produto: ");
            string descPro = Console.ReadLine();

            var produto = new ProdutoCad(descPro);

            Console.WriteLine("\nDigite a marca do produto: ");
            produto.marcaPro = Console.ReadLine();

            Console.WriteLine("\nDigite o tamanho do produto: ");
            produto.tamPro = Console.ReadLine();

            Console.WriteLine("\nDigite a cor do produto: ");
            produto.corPro = Console.ReadLine();

            Console.WriteLine("\nDigite a categoria do produto: ");
            produto.catPro = Console.ReadLine();

            Console.WriteLine("\nDigite o valor do produto: ");
            produto.valPro = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o peso do produto: ");
            produto.pesoPro = double.Parse(Console.ReadLine());

            listaProdutos.Add(produto);

            Console.WriteLine("\nO produto foi cadastrado com sucesso!");
            ListarProdutos();
        }

        public void ListarProdutos()
        {
            Console.WriteLine("\nProdutos Cadastrados:");
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.descPro}, Marca: {produto.marcaPro}, Valor: R${produto.valPro:F2}, Tamanho: {produto.tamPro}, Cor: {produto.corPro}, Categoria: {produto.catPro}, Peso: {produto.pesoPro}kg");
            }
        }
    }
}