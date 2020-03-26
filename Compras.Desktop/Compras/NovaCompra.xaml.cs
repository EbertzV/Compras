using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Compras.Desktop.Compras
{
    /// <summary>
    /// Lógica interna para NovaCompra.xaml
    /// </summary>
    public partial class TelaNovaCompra : Window
    {
        private readonly Compra _compra;
        public TelaNovaCompra()
        {
            _compra = new Compra(Guid.NewGuid(), "", DateTime.Now, new List<CompraItem>());
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _compra.AdicionarItem(new CompraItem(Guid.NewGuid(), DescricaoItem.Text, decimal.Parse(ValorItem.Text), int.Parse(QuantidadeItem.Text), ""));
            Label label = new Label();
            label.Content = DescricaoItem.Text;
            StackDescricao.Children.Add(label);

            Label label2 = new Label();
            label2.Content = ValorItem.Text;
            StackValorUnitario.Children.Add(label2);

            Label label3 = new Label();
            label3.Content = QuantidadeItem.Text;
            StackQuantidade.Children.Add(label3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComprasRepositorio repo = new ComprasRepositorio();
            repo.PersistirCompra(_compra);
        }
    }
}
