using System.ComponentModel;

namespace Compras.Desktop.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        public ItemViewModel(string descricao, decimal valorUnitario, int quantidade)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }

        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
