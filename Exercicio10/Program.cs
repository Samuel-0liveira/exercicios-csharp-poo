//Implemente uma classe chamada “Livro” com atributos para armazenar o título, o autor e o número de páginas do livro. 
//Adicione métodos para emprestar o livro, devolvê-lo e verificar se está disponível.

using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro controleDeLivros = new Livro("", "", 0);

            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();

                Console.WriteLine("1 - Incluir livro");
                Console.WriteLine("2 - Emprestar livro");
                Console.WriteLine("3 - Devolver livro");
                Console.WriteLine("4 - Verificar disponibilidade");
                Console.WriteLine("0 - Sair");
                Console.Write("O que deseja fazer?: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o título do livro(diferencie maiúscula de minúscula): ");
                        string titulo = Console.ReadLine()!;
                        Console.WriteLine("");

                        Console.Write("Digite o nome do autor do livro: ");
                        string autor = Console.ReadLine()!;
                        Console.WriteLine("");

                        Console.Write("Digite a quantidade de páginas do livro: ");
                        int paginas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        controleDeLivros.IncluirDevolverLivro(titulo, autor, paginas);

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o nome do livro que você quer pegar emprestado(diferencie maiúscula de minúscula): ");
                        string livroDesejado = Console.ReadLine()!;
                        Console.WriteLine("");
                        controleDeLivros.EmprestarLivro(livroDesejado);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o título que será devolvido(diferencie maiúscula de minúscula): ");
                        string tituloDaObra = Console.ReadLine()!;
                        Console.WriteLine("");
                        Console.Write("Digite o nome do autor do livro em questão: ");
                        string autorDaObra = Console.ReadLine()!;
                        Console.WriteLine("");
                        Console.Write("Digite a quantidade de páginas do livro: ");
                        int paginasDaObra = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        controleDeLivros.IncluirDevolverLivro(tituloDaObra, autorDaObra, paginasDaObra);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Digite o livro para verificar sua disponibilidade(diferencie maiúscula de minúscula): ");
                        string obra = Console.ReadLine()!;
                        controleDeLivros.VerificarDisponibilidade(obra);
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Clear();
                        Console.Write("Saindo...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}