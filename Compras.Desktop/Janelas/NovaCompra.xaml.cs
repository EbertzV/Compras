using Compras.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Compras.Desktop.Janelas
{
    public partial class TelaNovaCompra : Window
    {
        private CompraViewModel _compraViewModel;
        private int _cursorValorUnitarioPosicao;

        public TelaNovaCompra()
        {
            InitializeComponent();
            _compraViewModel = new CompraViewModel();
            this.DataContext = _compraViewModel;
            _cursorValorUnitarioPosicao = 0;
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
            try
            {
                _compraViewModel.AdicionarItemAtual();
                txtDescricao.Text = null;
                txtQuantidade.Text = "0";
                txtValorUnitario.Text = "R$ 0,00";
            }
            catch
            {
                return;
            }
        }

        private void txtQuantidade_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtValorUnitario_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if(Regex.IsMatch(e.Text, "[0-9]"))
            {
                return;
            } else if (Regex.IsMatch(e.Text, "^,$"))
            {
                if(Regex.IsMatch(txtValorUnitario.Text, ","))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var itens = new List<CompraItem>();
            foreach (var item in _compraViewModel.Itens)
                itens.Add(new CompraItem(Guid.NewGuid(), item.Descricao, item.ValorUnitario, item.Quantidade, ""));
            Compra compra = new Compra(Guid.NewGuid(), "", _compraViewModel.Data, itens);
            new ComprasRepositorio().PersistirCompra(compra);
            Close();
        }

        private void txtValorUnitario_GotFocus(object sender, RoutedEventArgs e)
        {
            txtValorUnitario.Text = "";
        }

        private void txtValorUnitario_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void txtQuantidade_GotFocus(object sender, RoutedEventArgs e)
        {
            txtQuantidade.Text = "";
        }
    }
}
