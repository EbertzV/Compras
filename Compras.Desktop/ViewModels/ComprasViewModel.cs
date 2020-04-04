using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class ComprasViewModel : INotifyPropertyChanged
    {
        public ComprasViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public IEnumerable<CompraViewModel> Compras{ get; set; }

        public override string ToString()
        {
            return "Mirtes";
        }
    }
}
