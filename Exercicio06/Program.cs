//Implemente uma classe chamada “Produto” que possua atributos para armazenar o nome, o preço e a quantidade em estoque. 
//Adicione métodos para calcular o valor total em estoque e verificar se o produto está disponível.

using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = PassarDados();
            produto.VerificarDisponibilidade(produto.EmEstoque);
            produto.CalculoValorTotalEmEstoque(produto.EmEstoque, produto.Preco);
        }

        private static Produto PassarDados()
        {
            Console.Clear();
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Digite o preço unitário desse produto R$: ");
            float preco = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora informe a quantidade em estoque: ");
            int emEstoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (emEstoque < 0)
            {
                emEstoque = 0;
            }

            return new Produto(nome, preco, emEstoque);
        }
    }
}