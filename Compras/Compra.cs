using System;
using System.Collections.Generic;

namespace Compras
{
    public sealed class Compra
    {
        public Compra(Guid id, string descricao, decimal valorTotal, DateTime data, IEnumerable<CompraItem> itens)
        {
            Id = id;
            Descricao = descricao;
            ValorTotal = valorTotal;
            Data = data;
            Itens = itens;
        }

        public Guid Id { get; }
        public string Descricao { get; }
        public decimal ValorTotal { get; }
        public DateTime Data { get; }
        public IEnumerable<CompraItem> Itens { get; }
    }

    public sealed class CompraItem
    {
        public Guid Id { get; }
        public string Descricao { get; }
        public decimal ValorUnitario { get; }
        public int Quantidade { get; }
        public string DescricaoUnidade { get; }
    }
}
