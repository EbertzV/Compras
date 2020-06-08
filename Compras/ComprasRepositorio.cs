using Compras.Dominio;
using Dapper;
using Powerstorm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Compras
{
    public sealed class ComprasRepositorio
    {
        private readonly string stringConexao = "Server=localhost;Database=compras;Integrated Security=true;";

        public Compra PersistirCompra(Compra compra)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                const string sql = @"INSERT INTO Compra (Id, Data, ValorTotal, Descricao, NotaFiscal) 
                                     VALUES (@Id, @Data, @ValorTotal, @Descricao, @NotaFiscal)";
                const string sqlItem = @"INSERT INTO CompraItem (Id, Descricao, ValorUnitario, Quantidade, IdCompra)
                                         VALUES (@Id, @Descricao, @ValorUnitario, @Quantidade, @IdCompra)";

                conexao.Open();

                using (var transaction = conexao.BeginTransaction())
                {
                    try
                    {
                        var resultadoCompra = conexao.Execute(sql, new { compra.Id, compra.Data, compra.ValorTotal, compra.Descricao, compra.NotaFiscal}, transaction);

                        foreach (var it in compra.Itens)
                        {
                            conexao.Execute(sqlItem, new { it.Id, it.Descricao, it.ValorUnitario, it.Quantidade, IdCompra = compra.Id }, transaction);
                        }

                        transaction.Commit();
                        return compra;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        public IEnumerable<Compra> RecuperarCompras(Paginacao paginacao)
        {
            const string sql = @"SELECT  Compra.Id,
		                                 Compra.Data,
		                                 Compra.ValorTotal,
		                                 Compra.Descricao,
		                                 Compra.NotaFiscal,
		                                 CompraItem.Id AS ItemId,
		                                 CompraItem.Descricao AS ItemDescricao,
		                                 CompraItem.ValorUnitario AS ItemValorUnitario,
		                                 CompraItem.Quantidade AS ItemQuantidade,
		                                 CompraItem.DescricaoUnidade AS ItemDescricaoUnidade
                                 FROM Compra (NOLOCK)
                                 INNER JOIN CompraItem (NOLOCK) ON CompraItem.IdCompra = Compra.Id";

            using (var conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    var resultado = conexao.Query(sql);

                    return resultado
                        .GroupBy(
                            d => new { d.Id, d.Descricao, d.Data, d.NotaFiscal, d.ValorTotal },
                            d => new CompraItem(d.ItemId, d.ItemDescricao, d.ItemValorUnitario, d.ItemQuantidade, d.ItemDescricaoUnidade),
                            (key, g) => new Compra(key.Id, key.Descricao, key.Data, g.ToList(), key.NotaFiscal, key.ValorTotal))
                        .OrderByDescending(b => b.Data)
                        .Skip((paginacao.PaginaAtual - 1) * paginacao.ResultadosPorPagina)
                        .Take(paginacao.ResultadosPorPagina);
                }
                catch (Exception ex)
                {
                     throw ex;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public sealed class ComprasViewModel
        {
            public ComprasViewModel(IEnumerable<Compra> compras, int totalResultados)
            {
                Compras = compras;
                TotalResultados = totalResultados;
            }

            public IEnumerable<Compra> Compras { get; }
            public int TotalResultados { get; }
        }

        public ComprasViewModel RecuperarCompras(Paginacao paginacao, FiltroCompras filtro)
        {
            string sql = @"SELECT Compra.Id,
                                  Compra.Data,
                                  Compra.ValorTotal,
                                  Compra.Descricao,
                                  Compra.NotaFiscal,
                                  CompraItem.Id AS ItemId,
                                  CompraItem.Descricao AS ItemDescricao,
                                  CompraItem.ValorUnitario AS ItemValorUnitario,
                                  CompraItem.Quantidade AS ItemQuantidade,
                                  CompraItem.DescricaoUnidade AS ItemDescricaoUnidade
                          FROM Compra (NOLOCK)
                          INNER JOIN CompraItem (NOLOCK) ON CompraItem.IdCompra = Compra.Id";

            using (var conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    var resultado = conexao.Query(sql);
                    var compras = resultado.GroupBy(
                            d => new { d.Id, d.Descricao, d.Data, d.NotaFiscal, d.ValorTotal },
                            d => new CompraItem(d.ItemId, d.ItemDescricao, d.ItemValorUnitario, d.ItemQuantidade, d.ItemDescricaoUnidade),
                            (key, g) => new Compra(key.Id, key.Descricao, key.Data, g.ToList(), key.NotaFiscal, key.ValorTotal))
                        .Where(a =>
                        {
                            if (filtro.DataMaxima != null && a.Data >= filtro.DataMaxima)
                                return false;
                            if (filtro.DataMinima != null && a.Data <= filtro.DataMinima)
                                return false;
                            if (filtro.ValorMaximo != null && a.ValorTotal >= filtro.ValorMaximo)
                                return false;
                            if (filtro.ValorMinimo != null && a.ValorTotal <= filtro.ValorMinimo)
                                return false;
                            return true;
                        })
                        .OrderByDescending(b => b.Data);
                    return new ComprasViewModel(
                        compras
                        .Skip((paginacao.PaginaAtual - 1) * paginacao.ResultadosPorPagina)
                        .Take(paginacao.ResultadosPorPagina), compras.Count());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public Compra RecuperarPorId(Guid id)
        {
            const string sql = @"SELECT  Compra.Id,
		                                 Compra.Data,
		                                 Compra.ValorTotal,
		                                 Compra.Descricao,
		                                 Compra.NotaFiscal,
		                                 CompraItem.Id AS ItemId,
		                                 CompraItem.Descricao AS ItemDescricao,
		                                 CompraItem.ValorUnitario AS ItemValorUnitario,
		                                 CompraItem.Quantidade AS ItemQuantidade,
		                                 CompraItem.DescricaoUnidade AS ItemDescricaoUnidade
                                 FROM Compra (NOLOCK)
                                 INNER JOIN CompraItem (NOLOCK) ON CompraItem.IdCompra = Compra.Id
                                 WHERE Compra.Id = @id";

            using (var conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    var resultado = conexao.Query(sql, new { id });
                    return resultado
                        .GroupBy(r => new { r.Id, r.Data, r.ValorTotal, r.Descricao, r.NotaFiscal })
                        .Select(c => new Compra(
                            c.Key.Id, 
                            c.Key.Descricao, 
                            c.Key.Data, 
                            c.Select(a => new CompraItem(
                                a.ItemId,
                                a.ItemDescricao, 
                                a.ItemValorUnitario, 
                                a.ItemQuantidade, 
                                a.ItemDescricaoUnidade)).ToList(),
                            c.Key.NotaFiscal,
                            c.Key.ValorTotal))
                        .FirstOrDefault();;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
