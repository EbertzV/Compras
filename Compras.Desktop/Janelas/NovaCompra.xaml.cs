using Compras.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Compras.Desktop.Janelas
{
    /// <summary>
    /// Lógica interna para NovaCompra.xaml
    /// </summary>
    /// 
    public partial class TelaNovaCompra : Window
    {
        private CompraViewModel _compraViewModel = new CompraViewModel();
        public TelaNovaCompra()
        {
            InitializeComponent();
            _compraViewModel.AdicionarItem(new ItemViewModel("Chocolate", 5.99M, 3));
            this.DataContext = _compraViewModel;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AdicionarItem(object sender, RoutedEventArgs e)
        {
            _compraViewModel.AdicionarItem(new ItemViewModel("Teste", 50M, 3));
        }
    }
}
