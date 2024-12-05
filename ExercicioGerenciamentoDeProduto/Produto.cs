using System.Globalization;

namespace ExercicioGerenciamentoDeProduto
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public int Codigo { get; set; }

        public string Nome
        {
            get => _nome;
            set => _nome = string.IsNullOrWhiteSpace(value) ? "indefinido" : value;
        }

        public double Preco
        {
            get => _preco;
            set => _preco = value < 0 ? 0 : value;
        }

        public int Quantidade
        {
            get => _quantidade;
            set => _quantidade = value < 0 ? 0 : value;
        }

        public Produto(int codigo, string nome, double preco, int quantidade)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        public string ExibirInfomacoes()
        {
            return $"Código do produto: {Codigo}\n" +
                $"Nome: {Nome}\n" +
                $"Preco: {PrecoToString()}\n" +
                $"Quantidade: {Quantidade}\n" +
                $"Valor Total: {ValorTotalToString()}";
        }

        private double ValorTotal()
        { 
            return Preco * Quantidade;
        }

        private string PrecoToString()
        { 
            return Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        private string ValorTotalToString()
        {
            return ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
