using Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NovaCompra : Window
    {
        private IList<CompraItem> listaItens;
        public MainWindow()
        {
            InitializeComponent();
            listaItens = new List<CompraItem>();
            Itens.ItemsSource = listaItens;
        }

        private void CadastrarCompra_Click(object sender, RoutedEventArgs e)
        {
            Compra compra = new Compra(Guid.NewGuid(), TBDescricaoCompra.Text, DPDataCompra.DisplayDate, listaItens);
            ComprasRepositorio repositorio = new ComprasRepositorio();
            var task = Task.Run(() => repositorio.PersistirCompra(compra));
            task.GetAwaiter().GetResult();
        }

        private void CadastrarItem_Click(object sender, RoutedEventArgs e)
        {
            listaItens.Add(new CompraItem(Guid.NewGuid(), TB_DescricaoItem.Text, decimal.Parse(TB_ValorUnitarioItem.Text), int.Parse(TB_QtdItem.Text), ""));
        }
    }
}
