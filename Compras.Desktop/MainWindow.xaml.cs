using Compras.Desktop.Compras;
using System.Windows;

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
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ListaCompras listaCompras = new ListaCompras();
            listaCompras.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TelaNovaCompra novaCompra = new TelaNovaCompra();
            novaCompra.Show();
        }
    }
}
