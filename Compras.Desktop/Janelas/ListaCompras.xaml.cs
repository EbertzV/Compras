using Compras.Desktop.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Compras.Desktop.Janelas
{
    public partial class ListaCompras : Window
    {
        public ObservableCollection<CompraViewModel> _compras;
        public ComprasViewModel ComprasModel;
        public int paginaAtual;
        public ListaCompras()
        {
            InitializeComponent();
           

            paginaAtual = 1;
            ComprasModel = new ComprasViewModel();
            ComprasModel.Compras = new ObservableCollection<CompraViewModel>(
                new ComprasRepositorio()
                    .RecuperarCompras(new Powerstorm.Paginacao(paginaAtual - 1, ComprasModel.ResultadosPorPagina))
                    .Select(c => new CompraViewModel(
                        new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                            i.Descricao,
                            i.ValorUnitario,
                            i.Quantidade))),
                        c.Data,
                        c.ValorTotal)));
            DataContext = ComprasModel;
            Btn_PgAnterior.Visibility = Visibility.Hidden;
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
            ComprasModel.Compras = new ObservableCollection<CompraViewModel>(
                new ComprasRepositorio()
                    .RecuperarCompras(new Powerstorm.Paginacao(ComprasModel.ProximaPagina - 1, ComprasModel.ResultadosPorPagina))
                    .Select(c => new CompraViewModel(
                        new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                            i.Descricao,
                            i.ValorUnitario,
                            i.Quantidade))),
                        c.Data,
                        c.ValorTotal)));
            if (ComprasModel.PaginaAtual > 1)
                Btn_PgAnterior.Visibility = Visibility.Visible;
            else
                Btn_PgAnterior.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ComprasModel.Compras = new ObservableCollection<CompraViewModel>(
               new ComprasRepositorio()
                   .RecuperarCompras(new Powerstorm.Paginacao(ComprasModel.PaginaAnterior - 1, ComprasModel.ResultadosPorPagina))
                   .Select(c => new CompraViewModel(
                       new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                           i.Descricao,
                           i.ValorUnitario,
                           i.Quantidade))),
                       c.Data,
                       c.ValorTotal)));
            if (ComprasModel.PaginaAtual > 1)
                Btn_PgAnterior.Visibility = Visibility.Visible;
            else
                Btn_PgAnterior.Visibility = Visibility.Hidden;
        }

        private void DataGridRow_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            switch (((DataGridRow)sender).DetailsVisibility)
            {
                case Visibility.Visible:
                    ((DataGridRow)sender).DetailsVisibility = Visibility.Collapsed;
                    break;
                case Visibility.Collapsed:
                    ((DataGridRow)sender).DetailsVisibility = Visibility.Visible;
                    break;

                default:
                    return;
            }
        }

        private void Btn_ListaCompras_Pesquisar_Handler(object sender, RoutedEventArgs e)
        {
            var repositorio = new ComprasRepositorio();
            var paginacao = new Powerstorm.Paginacao(paginaAtual, 10);
            var _compras = new ObservableCollection<CompraViewModel>(repositorio
                .RecuperarCompras(paginacao, new Dominio.FiltroCompras(
                    DP_ListaCompras_FiltroDataMaxima.SelectedDate,
                    DP_ListaCompras_FiltroDataMinima.SelectedDate,
                    String.IsNullOrWhiteSpace(TB_ListaCompras_FiltroValorMaximo.Text) ? (decimal?)null : decimal.Parse(TB_ListaCompras_FiltroValorMaximo.Text),
                    String.IsNullOrWhiteSpace(TB_ListaCompras_FiltroValorMinimo.Text) ? (decimal?)null : decimal.Parse(TB_ListaCompras_FiltroValorMinimo.Text)))
                .Select(c => new CompraViewModel(
                    new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                        i.Descricao,
                        i.ValorUnitario,
                        i.Quantidade))),
                    c.Data,
                    c.ValorTotal)));

            ComprasModel.Compras.Clear();
            foreach (var compra in _compras)
                ComprasModel.Compras.Add(compra);
        }
    }
}
