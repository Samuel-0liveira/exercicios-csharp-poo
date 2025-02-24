using System.Globalization;

namespace Exercicio06
{
    class Produto
    {
        public Produto(string nome, float preco, int emEstoque)
        {
            Nome = nome;
            Preco = preco;
            EmEstoque = emEstoque;
        }

        public string Nome { get; set; }
        public float Preco { get; set; }
        public int EmEstoque { get; set; }

        internal void CalculoValorTotalEmEstoque(int estoque, float precoUnitario)
        {
            float total = estoque * precoUnitario;
            Console.WriteLine($"O valor total do produto em estoque é de: {total.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
            Console.WriteLine("");
        }

        internal void VerificarDisponibilidade(int estoque)
        {
            if (estoque > 0)
            {
                Console.WriteLine("O produto se encontra disponível!");
            } else {
                Console.WriteLine("O produto não se encontra disponível!");
            }
        }
    }
}