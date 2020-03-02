using System;
using System.Collections.Generic;
using System.Linq;

namespace Compras
{
    public sealed class Compra
    {
        public Compra(Guid id, string descricao, DateTime data, IEnumerable<CompraItem> itens, string notaFiscal = "", decimal? valorTotal = null)
        {
            Id = id;
            Descricao = descricao;
            ValorTotal = valorTotal == null ? itens.Sum(i => i.ValorUnitario * i.Quantidade) : (decimal) valorTotal;
            Data = data;
            Itens = itens;
            NotaFiscal = notaFiscal;
        }

        public Guid Id { get; }
        public string Descricao { get; }
        public decimal ValorTotal { get; }
        public DateTime Data { get; }
        public IEnumerable<CompraItem> Itens { get; }
        public string NotaFiscal { get; }
    }

    public sealed class CompraItem
    {
        public CompraItem(Guid id, string descricao, decimal valorUnitario, int quantidade, string descricaoUnidade)
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            DescricaoUnidade = descricaoUnidade;
        }

        public Guid Id { get; }
        public string Descricao { get; }
        public decimal ValorUnitario { get; }
        public int Quantidade { get; }
        public string DescricaoUnidade { get; }
    }
}
