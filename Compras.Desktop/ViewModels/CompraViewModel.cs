using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class CompraViewModel : INotifyPropertyChanged
    {
        public CompraViewModel()
        {
            Itens = new List<ItemViewModel>();
            Data = DateTime.Now;
            ValorTotal = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged = (o, sender) => { };

        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<ItemViewModel> Itens{ get; set; }

        public void AdicionarItem(ItemViewModel item)
        {
            Itens.Add(item);
            ValorTotal = ValorTotal + (item.ValorUnitario * item.Quantidade);
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(Itens)));
        }

        public void AlterarData(DateTime data) 
            => Data = data;

        public void ForcarValor(decimal valorTotal)
            => ValorTotal = valorTotal;
    }
}
