using System.Runtime.CompilerServices;

namespace Exercicio10
{
    class Livro
    {
        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public List<string> LivrosEmEstoque { get; set; } = new List<string>();

        public void IncluirDevolverLivro(string nomeLivro, string autor, int paginasDoLivro)
        {
            string novoLivro = $"Nome do livro: {nomeLivro} - Nome do autor: {autor} - Número de páginas: {paginasDoLivro}";
            LivrosEmEstoque.Add(novoLivro);
            Console.WriteLine("Livro incluso!");
        }
        
        public void EmprestarLivro(string nomeDoLivro)
        {
            int emprestado = 0;

            foreach (var livro in LivrosEmEstoque.ToList())
            {
                if (livro.Substring(15, nomeDoLivro.Length).Equals(nomeDoLivro))
                {
                    emprestado++;
                    LivrosEmEstoque.Remove(livro);
                }
            }

            if (emprestado > 0)
            {
                Console.WriteLine("Livro emprestado com sucesso.");
            } else {
                Console.WriteLine("Livro indisponível para empréstimo.");
            }
            
        }

        public void VerificarDisponibilidade(string nome)
        {
            int disponivel = 0;

            foreach (var livro in LivrosEmEstoque.ToList())
            {
                if (livro.Substring(15, nome.Length).Equals(nome))
                {
                    disponivel++;
                }
            }

            if (disponivel > 0)
            {
                Console.WriteLine("O livro se encontra disponível!");
            } else {
                Console.WriteLine("O livro se encontra indisponível!");
            }
        }

        //Método para exbir livros disponíveis na lista, caso prefira ao invés de verificar a disponibilidade
        public void ExibirLivrosEmEstoque()
        {
            foreach (var livro in LivrosEmEstoque)
            {
                Console.WriteLine(livro);
            }
        }
    }
}