namespace Compras.Dominio.Utils
{
    public sealed class DinheiroWrapper
    {
        private readonly int _maxLength;
        private int _casaAtual;
        public DinheiroWrapper(int maxLength)
        {
            Valor = 0;
            _casaAtual = 1;
            _maxLength = maxLength;
        }

        public void AdicionarDigito(int digito)
        {
            if (_casaAtual >= _maxLength)
                return;
            string valorAtual = ValorTexto.Substring(0, ValorTexto.Length - 3) + ValorTexto.Substring(ValorTexto.Length - 2);

            //Alteração
            string valorAlterado = valorAtual.Substring(0, valorAtual.Length - _casaAtual) + digito;
            valorAlterado = _casaAtual > 0 ? valorAlterado + valorAtual.Substring(valorAtual.Length - _casaAtual, _casaAtual) : valorAtual;
            Valor = decimal.Parse(valorAlterado) / 100;
        }

        public decimal Valor { get; private set; }
        public string ValorTexto
        {
            get
            {
                return string.Format("{0:N2}", Valor);
            }
        }

    }
}
