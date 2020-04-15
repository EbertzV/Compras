using Compras.Desktop.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Compras.Desktop.Janelas
{
    /// <summary>
    /// Lógica interna para Compras.xaml
    /// </summary>
    public partial class ListaCompras : Window
    {
        public ObservableCollection<CompraViewModel> _compras;
        public ComprasViewModel Compras;
        public int paginaAtual;
        public ListaCompras()
        {
            InitializeComponent();
            paginaAtual = 1;
            Compras = new ComprasViewModel();
            Compras.Compras = new ObservableCollection<CompraViewModel>(
                new ComprasRepositorio()
                    .RecuperarCompras(new Powerstorm.Paginacao(paginaAtual - 1, Compras.ResultadosPorPagina))
                    .Select(c => new CompraViewModel(
                        new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                            i.Descricao, 
                            i.ValorUnitario, 
                            i.Quantidade))), 
                        c.Data, 
                        c.ValorTotal)));
            
            DataContext = Compras;
            Btn_PgAnterior.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ExibirItensCompra(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TelaNovaCompra tela = new TelaNovaCompra();
            tela.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Compras.Compras = new ObservableCollection<CompraViewModel>(
                new ComprasRepositorio()
                    .RecuperarCompras(new Powerstorm.Paginacao(Compras.ProximaPagina - 1, Compras.ResultadosPorPagina))
                    .Select(c => new CompraViewModel(
                        new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                            i.Descricao,
                            i.ValorUnitario,
                            i.Quantidade))),
                        c.Data,
                        c.ValorTotal)));
            if (Compras.PaginaAtual > 1)
                Btn_PgAnterior.Visibility = Visibility.Visible;
            else
                Btn_PgAnterior.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Compras.Compras = new ObservableCollection<CompraViewModel>(
               new ComprasRepositorio()
                   .RecuperarCompras(new Powerstorm.Paginacao(Compras.PaginaAnterior - 1, Compras.ResultadosPorPagina))
                   .Select(c => new CompraViewModel(
                       new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                           i.Descricao,
                           i.ValorUnitario,
                           i.Quantidade))),
                       c.Data,
                       c.ValorTotal)));
            if (Compras.PaginaAtual > 1)
                Btn_PgAnterior.Visibility = Visibility.Visible;
            else
                Btn_PgAnterior.Visibility = Visibility.Hidden;
        }
    }
}
