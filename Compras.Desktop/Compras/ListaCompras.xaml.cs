using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Compras.Desktop.Compras
{
    /// <summary>
    /// Lógica interna para Compras.xaml
    /// </summary>
    public partial class ListaCompras : Window
    {
        public ListaCompras()
        {
            var comprasRepositorio = new ComprasRepositorio();
            var compras = comprasRepositorio.RecuperarCompras(new Powerstorm.Paginacao(0, 100));
            InitializeComponent();  

            DG_Lista_Compras.ItemsSource = compras;
        } 
    }
}
