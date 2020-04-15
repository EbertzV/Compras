using Compras.Desktop.Janelas;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Compras.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var t = new TreeViewItem();
        }

        private void AbrirJanelaComprasEfetuadas(object sender, RoutedEventArgs e)
        {
            ListaCompras lista = new ListaCompras();
            lista.Show();
        }
        private void AbrirJanelaCadastrarNovaCompra(object sender, RoutedEventArgs e)
        {
            TelaNovaCompra tela = new TelaNovaCompra();
            tela.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
