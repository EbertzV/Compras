using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa Cadastrar Compra");

            Console.WriteLine("Informe a data da compra: ");
            var data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Descreva a compra: ");
            var descricao = Console.ReadLine();

            Console.WriteLine("Loop dos itens:");
            char inserirItem = Console.ReadKey().KeyChar;

            var itens = new List<CompraItem>();

            while(inserirItem != 'n')
            {
                Console.WriteLine("Descreva o item: ");
                var descricaoItem = Console.ReadLine();
                Console.WriteLine("Digite o valor unitário: ");
                decimal valorUnitario = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                itens.Add(new CompraItem(Guid.NewGuid(), descricaoItem, valorUnitario, quantidade, ""));

                Console.WriteLine("Adicionar mais itens? (s/n)");
                inserirItem = Console.ReadKey().KeyChar;
            }

            var compra = new Compra(Guid.NewGuid(), descricao, data, itens);

            

        }
    }
}
