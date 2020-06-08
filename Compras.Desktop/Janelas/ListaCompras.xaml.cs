using Compras.Desktop.ViewModels;
using Compras.Dominio;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            var resultado = new ComprasRepositorio().RecuperarCompras(new Powerstorm.Paginacao(paginaAtual - 1, ComprasModel.ResultadosPorPagina), new FiltroCompras(null, null, null, null));
            var compras = new ObservableCollection<CompraViewModel>( 
                resultado
                    .Compras
                    .Select(c => new CompraViewModel(
                        new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                            i.Descricao,
                            i.ValorUnitario,
                            i.Quantidade))),
                        c.Data,
                        c.ValorTotal,
                        c.NotaFiscal)));
            ComprasModel.Compras = compras;
            ComprasModel.QtdResultados = resultado.TotalResultados;
            Btn_ProxPg.Visibility = ComprasModel.ExibirProximaPagina ? Visibility.Visible : Visibility.Hidden;
            Btn_PgAnterior.Visibility = ComprasModel.ExibirPaginaAnterior ? Visibility.Visible : Visibility.Hidden;
            DataContext = ComprasModel;
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
            var repositorio = new ComprasRepositorio();
            var paginacao = new Powerstorm.Paginacao(ComprasModel.ProximaPagina, ComprasModel.ResultadosPorPagina);
            var _compras = new ObservableCollection<CompraViewModel>(repositorio
                .RecuperarCompras(paginacao, new Dominio.FiltroCompras(
                    ComprasModel.FiltroDataMaxima,
                    ComprasModel.FiltroDataMinima,
                    ComprasModel.FiltroValorMaximo,
                    ComprasModel.FiltroValorMinimo))
                .Compras
                .Select(c => new CompraViewModel(
                    new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                        i.Descricao,
                        i.ValorUnitario,
                        i.Quantidade))),
                    c.Data,
                    c.ValorTotal,
                    c.NotaFiscal)));

            ComprasModel.Compras.Clear();
            foreach (var compra in _compras)
                ComprasModel.Compras.Add(compra);
            

            ComprasModel.PaginaAtual = ComprasModel.ProximaPagina;
            Btn_ProxPg.Visibility = ComprasModel.ExibirProximaPagina ? Visibility.Visible : Visibility.Hidden;
            Btn_PgAnterior.Visibility = ComprasModel.ExibirPaginaAnterior ? Visibility.Visible : Visibility.Hidden;
            lblPgAtual.Text = ComprasModel.PaginaAtual.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var repositorio = new ComprasRepositorio();
            var paginacao = new Powerstorm.Paginacao(ComprasModel.PaginaAnterior, ComprasModel.ResultadosPorPagina);
            var _compras = new ObservableCollection<CompraViewModel>(repositorio
                .RecuperarCompras(paginacao, new Dominio.FiltroCompras(
                    ComprasModel.FiltroDataMaxima,
                    ComprasModel.FiltroDataMinima,
                    ComprasModel.FiltroValorMaximo,
                    ComprasModel.FiltroValorMinimo))
                .Compras
                .Select(c => new CompraViewModel(
                    new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                        i.Descricao,
                        i.ValorUnitario,
                        i.Quantidade))),
                    c.Data,
                    c.ValorTotal,
                    c.NotaFiscal)));

            ComprasModel.Compras.Clear();
            foreach (var compra in _compras)
                ComprasModel.Compras.Add(compra);

            ComprasModel.PaginaAtual = ComprasModel.PaginaAnterior;
            Btn_ProxPg.Visibility = ComprasModel.ExibirProximaPagina ? Visibility.Visible : Visibility.Hidden;
            Btn_PgAnterior.Visibility = ComprasModel.ExibirPaginaAnterior ? Visibility.Visible : Visibility.Hidden;
            lblPgAtual.Text = ComprasModel.PaginaAtual.ToString();
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
            ComprasModel.FiltroDataMaxima = DP_ListaCompras_FiltroDataMaxima.SelectedDate;
            ComprasModel.FiltroDataMinima = DP_ListaCompras_FiltroDataMinima.SelectedDate;
            ComprasModel.FiltroValorMaximo = String.IsNullOrWhiteSpace(TB_ListaCompras_FiltroValorMaximo.Text) ? (decimal?)null : decimal.Parse(TB_ListaCompras_FiltroValorMaximo.Text);
            ComprasModel.FiltroValorMinimo = String.IsNullOrWhiteSpace(TB_ListaCompras_FiltroValorMinimo.Text) ? (decimal?)null : decimal.Parse(TB_ListaCompras_FiltroValorMinimo.Text);


            var repositorio = new ComprasRepositorio();
            var paginacao = new Powerstorm.Paginacao(1, ComprasModel.ResultadosPorPagina);
            var _compras = new ObservableCollection<CompraViewModel>(repositorio
                .RecuperarCompras(paginacao, new Dominio.FiltroCompras(
                    ComprasModel.FiltroDataMaxima,
                    ComprasModel.FiltroDataMinima,
                    ComprasModel.FiltroValorMaximo,
                    ComprasModel.FiltroValorMinimo))
                .Compras
                .Select(c => new CompraViewModel(
                    new ObservableCollection<ItemViewModel>(c.Itens.Select(i => new ItemViewModel(
                        i.Descricao,
                        i.ValorUnitario,
                        i.Quantidade))),
                    c.Data,
                    c.ValorTotal,
                    c.NotaFiscal)));

            ComprasModel.Compras.Clear();
            foreach (var compra in _compras)
                ComprasModel.Compras.Add(compra);

            ComprasModel.PaginaAtual = 1;
            Btn_ProxPg.Visibility = ComprasModel.ExibirProximaPagina ? Visibility.Visible : Visibility.Hidden;
            Btn_PgAnterior.Visibility = ComprasModel.ExibirPaginaAnterior ? Visibility.Visible : Visibility.Hidden;
            lblPgAtual.Text = ComprasModel.PaginaAtual.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ComprasModel.FiltroDataMaxima = null;
            ComprasModel.FiltroDataMinima = null;
            ComprasModel.FiltroValorMaximo = null;
            ComprasModel.FiltroValorMinimo = null;
            DP_ListaCompras_FiltroDataMaxima.SelectedDate = null;
            DP_ListaCompras_FiltroDataMinima.SelectedDate = null;
            TB_ListaCompras_FiltroValorMaximo.Text = null;
            TB_ListaCompras_FiltroValorMinimo.Text = null;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TelaNovaCompra tela = new TelaNovaCompra();
            tela.ShowDialog();
            Console.ReadKey();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
