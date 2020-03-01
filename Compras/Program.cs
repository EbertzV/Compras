using System;
using System.Collections.Generic;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa Cadastrar Compra");

            Console.WriteLine("Informe a data da compra: ");
            var data = Console.ReadLine();

            Console.WriteLine("Descreva a compra: ");
            var descricao = Console.ReadLine();

            Console.WriteLine("Loop dos itens:");
            char inserirItem = Console.ReadKey().KeyChar;

            var itens = new List<CompraItem>();

            while(inserirItem != 'n')
            {
                Console.WriteLine("");
                var descricaoItem = Console.ReadLine();
                Console.WriteLine("");
                var valorUnitario = Console.ReadLine();
                Console.WriteLine("");
                var quantidade = Console.ReadLine();

                Console.WriteLine("Adicionar mais itens? (s/n)");
                inserirItem = Console.ReadKey().KeyChar;
            }
        }
    }
}
