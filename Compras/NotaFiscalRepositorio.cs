using System;
using System.IO;
using System.Reflection;

namespace Compras.Dominio
{
    public sealed class NotaFiscalRepositorio
    {
        private readonly string _caminhoImagens;
        public NotaFiscalRepositorio(string caminho)
        {
            _caminhoImagens = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\NF";
            if (!Directory.Exists(_caminhoImagens))
                Directory.CreateDirectory(_caminhoImagens);
        }
        public string PersistirImagem(string caminhoOriginal)
        {
            string nome = Guid.NewGuid().ToString();
            File.Copy(caminhoOriginal, $"{_caminhoImagens}\\{nome}.png");
            return nome;
        }
    }
}
