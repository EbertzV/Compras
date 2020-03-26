using System;
using System.Collections.Generic;
using System.Linq;

namespace Compras
{
    public sealed class Compra
    {
        public Compra(Guid id, string descricao, DateTime data, IList<CompraItem> itens, string notaFiscal = "", decimal? valorTotal = null)
        {
            Id = id;
            Descricao = descricao;
            ValorTotal = valorTotal == null ? itens.Sum(i => i.ValorUnitario * i.Quantidade) : (decimal) valorTotal;
            Data = data;
            Itens = itens;
            NotaFiscal = notaFiscal;
        }

        public Guid Id { get; }
        public string Descricao { get; private set; }
        public decimal ValorTotal { get; private set; }
        public DateTime Data { get; private set; }
        public IList<CompraItem> Itens { get; }
        public string NotaFiscal { get; }

        public void AdicionarItem(CompraItem item)
        {
            Itens.Add(item);
            ValorTotal = ValorTotal + (item.ValorUnitario * item.Quantidade);
        }

        public void AdicionarData(DateTime data)
            => Data = data;

        public void DefinirDescricao(string descricao)
            => Descricao = descricao;
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
