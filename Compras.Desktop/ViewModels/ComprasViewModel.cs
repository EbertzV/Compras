using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class ComprasViewModel : INotifyPropertyChanged
    {
        public ComprasViewModel()
        {
            PaginaAtual = 1;
            ResultadosPorPagina = 10;
            ExibirDetalhes = false;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        public ObservableCollection<CompraViewModel> Compras{ get; set; }
        public bool ExibirDetalhes { get; set; }
        public int PaginaAtual { get; set; }
        public int PaginaAnterior { get { if (PaginaAtual < 2) return PaginaAtual; else return PaginaAtual - 1; } }
        public int ResultadosPorPagina { get; set; }
        public int ProximaPagina 
        {
            get 
            {
                return PaginaAtual + 1; 
            } 
        }

        public override string ToString()
        {
            return ToString();
        }
    }
}
