using Dapper;
using Powerstorm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Compras
{
    public sealed class ComprasRepositorio
    {
        private readonly string stringConexao = "Server=DESKTOP-S8RPACC;Database=compras;Integrated Security=true;";

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
                        var resultadoCompra = conexao.Execute(sql, new { compra.Id, compra.Data, compra.ValorTotal, compra.Descricao, NotaFiscal = "" }, transaction);

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
    }
}
