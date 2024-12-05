using System.Globalization;

namespace ExercicioGerenciamentoDeProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(codigo, nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine(produto.ExibirInfomacoes());

        }
    }
}
