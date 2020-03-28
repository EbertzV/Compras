using System;
using System.Windows;
using System.Windows.Controls;

namespace Compras.Desktop.Janelas
{
    /// <summary>
    /// Lógica interna para Compras.xaml
    /// </summary>
    public partial class ListaCompras : Window
    {
        private readonly ComprasRepositorio _comprasRepositorio;
        public ListaCompras()
        {
            _comprasRepositorio = new ComprasRepositorio();
            InitializeComponent();  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var compras = _comprasRepositorio.RecuperarCompras(new Powerstorm.Paginacao(0, 100));
            ComprasEfetuadasView.Items.Clear();
            foreach (var compra in compras)
            {
                var item = new TreeViewItem();
                item.Header = compra.Data.ToString();
                item.Tag = compra.Id.ToString();
                item.Expanded += ExibirItensCompra;
                ComprasEfetuadasView.Items.Add(item);
            }
        }

        private void ExibirItensCompra(object sender, RoutedEventArgs e)
        {
            var itemSelecionado = (TreeViewItem)sender;
            if (!Guid.TryParse((string)itemSelecionado.Tag, out Guid idCompra))
                return;
            var compra = _comprasRepositorio.RecuperarPorId(idCompra);
            itemSelecionado.Items.Clear();
            foreach (var item in compra.Itens)
            {
                var subItem = new TreeViewItem();
                subItem.Header = item.Descricao;
                subItem.Tag = item.Quantidade;
                itemSelecionado.Items.Add(subItem);
            }
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
    }
}
