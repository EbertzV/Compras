using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Compras.Desktop.Janelas
{
    [ValueConversion(typeof(decimal), typeof(string))]
    public class DinheiroValueConverter : IValueConverter
    {
        public static DinheiroValueConverter Instance = new DinheiroValueConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is decimal valor)
                return string.Format("R$ {0:N2}", valor);
            else return "R$ 0,00";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string valor && decimal.TryParse(valor, out decimal resultado))
            {
                return resultado;
            }
            else
            {
                return -1;
            }
        }
    }
}
