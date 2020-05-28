using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class ComprasViewModel : INotifyPropertyChanged
    {
        public ComprasViewModel()
        {
            PaginaAtual = 1;
            ResultadosPorPagina = 1;
            ExibirDetalhes = false;
            QtdResultados = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => 
        {
        };

        public ObservableCollection<CompraViewModel> Compras{ get; set; }
        public bool ExibirDetalhes { get; set; }
        public int QtdResultados { get; set; }
        public int QtdPaginas { get { return QtdResultados % ResultadosPorPagina; } }
        public int PaginaAtual { get; set; }
        public int PaginaAnterior { get { if (PaginaAtual < 2) return PaginaAtual; else return PaginaAtual - 1; } }
        public int ResultadosPorPagina { get; set; }
        public bool ExibirProximaPagina { get { return PaginaAtual < QtdPaginas; } }
        public bool ExibirPaginaAnterior { get { return PaginaAtual > 1; } }
        public decimal? FiltroValorMinimo { get; set; }
        public decimal? FiltroValorMaximo { get; set; }
        public DateTime? FiltroDataMinima { get; set; }
        public DateTime? FiltroDataMaxima { get; set; }
        public int ProximaPagina 
        {
            get 
            {
                return PaginaAtual + 1; 
            } 
        }
    }
}
