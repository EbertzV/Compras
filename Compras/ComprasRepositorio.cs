using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Compras
{
    public sealed class ComprasRepositorio
    {
        private readonly string stringConexao = "Server=DESKTOP-S8RPACC;Database=compras;Integrated Security=true;";

        public async Task<Compra> PersistirCompra(Compra compra)
        {
            

            using (var conexao = new SqlConnection(stringConexao))
            {
                const string sql = @"INSERT INTO Compra (Id, Data, ValorTotal, Descricao, NotaFiscal) 
                                     VALUES (@Id, @Data, @ValorTotal, @Descricao, @NotaFiscal)";
                const string sqlItem = @"INSERT INTO CompraItem (Id, Descricao, ValorUnitario, Quantidade, IdCompra)
                                         VALUES (@Id, @Descricao, @ValorUnitario, @Quantidade, @IdCompra)";

                await conexao.OpenAsync();

                using (var transaction = conexao.BeginTransaction())
                {
                    try
                    {
                        var resultadoCompra = await conexao.ExecuteAsync(sql, new { compra.Id, compra.Data, compra.ValorTotal, compra.Descricao, NotaFiscal = "" });

                        foreach (var it in compra.Itens)
                        {
                            await conexao.ExecuteAsync(sqlItem, new { it.Id, it.Descricao, it.ValorUnitario, it.Quantidade, IdCompra = compra.Id });
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

        public async Task<IEnumerable<Compra>> RecuperarCompras()
        {

        }
    }
}
