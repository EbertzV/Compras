using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class CompraViewModel : INotifyPropertyChanged
    {
        public CompraViewModel()
        {
            Itens = new ObservableCollection<ItemViewModel>();
            Data = DateTime.Now;
            ValorTotal = 0;
            ItemAtual = ItemViewModel.NovoVazio();
        }

        public CompraViewModel(ObservableCollection<ItemViewModel> itens, DateTime data, decimal valorTotal)
        {
            Itens = itens;
            Data = data;
            ValorTotal = valorTotal;
            ItemAtual = ItemViewModel.NovoVazio();
        }

        public event PropertyChangedEventHandler PropertyChanged = (o, sender) => { };

        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public ObservableCollection<ItemViewModel> Itens{ get; set; }
        public ItemViewModel ItemAtual { get; set; }

        public void AdicionarItem(ItemViewModel item)
        {
            Itens.Add(item);
            ValorTotal = ValorTotal + (item.ValorUnitario * item.Quantidade);
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(Itens)));
        }

        public void AdicionarItemAtual()
        {
            Itens.Add(new ItemViewModel(ItemAtual.Descricao, ItemAtual.ValorUnitario, ItemAtual.Quantidade));
            ItemAtual.Descricao = "";
            ItemAtual.ValorUnitario = 0M;
            ItemAtual.Quantidade = 0;
        }

        public void AlterarData(DateTime data) 
            => Data = data;

        public void ForcarValor(decimal valorTotal)
            => ValorTotal = valorTotal;
    }
}
