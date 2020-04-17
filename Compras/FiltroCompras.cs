using System;

namespace Compras.Dominio
{
    public sealed class FiltroCompras
    {
        public FiltroCompras(DateTime? dataMaxima, DateTime? dataMinima, decimal? valorMaximo, decimal? valorMinimo)
        {
            DataMaxima = dataMaxima;
            DataMinima = dataMinima;
            ValorMaximo = valorMaximo;
            ValorMinimo = valorMinimo;
        }

        public DateTime? DataMaxima { get; }
        public DateTime? DataMinima { get; }
        public decimal? ValorMaximo { get; }
        public decimal? ValorMinimo { get; }
    }
}
