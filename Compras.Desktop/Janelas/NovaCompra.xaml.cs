using Compras.Desktop.ViewModels;
using Compras.Dominio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Compras.Desktop.Janelas
{
    public partial class TelaNovaCompra : Window
    {
        private CompraViewModel _compraViewModel;
        private readonly string _caminhoPrograma;
        public TelaNovaCompra()
        {
            InitializeComponent();
            _compraViewModel = new CompraViewModel();
            _caminhoPrograma = "C:\\temp";
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
            if (Regex.IsMatch(e.Text, "[0-9]"))
            {
                return;
            }
            else if (Regex.IsMatch(e.Text, "^,$"))
            {
                if (Regex.IsMatch(txtValorUnitario.Text, ","))
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
            var nomeArquivoNotaFiscal = new NotaFiscalRepositorio($"{_caminhoPrograma}\\NF").PersistirImagem(_compraViewModel.NotaFiscal);
            Compra compra = new Compra(Guid.NewGuid(), "", _compraViewModel.Data, itens, nomeArquivoNotaFiscal);
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos PNG (*.png)|*.png|Arquivos JPG (*.jpg)|*.jpg|Arquivos JPEG (*.jpeg)|*.jpeg|Arquivos Bitmap (*.bmp)|*.bmp|Todos os arquivos (*.*)|*.*";
            ofd.InitialDirectory = @"C:";
            ofd.ShowDialog();
            _compraViewModel.NotaFiscal = ofd.FileName;
            lblNomeArquivo.Text = ofd.FileName;
        }
    }
}
