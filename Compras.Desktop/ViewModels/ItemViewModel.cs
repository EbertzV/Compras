using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private decimal _valorUnitario;
        public ItemViewModel(string descricao, decimal valorUnitario, int quantidade)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            _valorUnitario = valorUnitario;
        }

        public string Descricao { get; set; }
        public decimal ValorUnitario 
        {
            get 
            { 
                return _valorUnitario; 
            } 
            set 
            {
                var valor = value;
                if(valor < 0M)
                {
                    return;
                }
                else
                {
                    _valorUnitario = valor;
                }
            } 
        }
        public int Quantidade { get; set; }

        public static ItemViewModel NovoVazio()
            => new ItemViewModel("", 0, 0);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
