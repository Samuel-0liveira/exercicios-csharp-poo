//Implemente uma classe chamada “Aluno” que possua atributos para armazenar o nome, a matrícula e as notas de um aluno. 
//Adicione métodos para calcular a média das notas e verificar a situação do aluno (aprovado ou reprovado).

using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = PedirInformacoes();
            float mediaDoAluno = aluno.CalcularMedia(aluno.Notas);
            string verificarAprovacao = aluno.Aprovacao(mediaDoAluno);
            
            Console.Clear();
            Console.WriteLine($"Nome do aluno: {aluno.Nome}\nNúmero da matrícula: {aluno.Matricula}\nA média do aluno foi de: {mediaDoAluno:n1}\n{verificarAprovacao}");
            Console.ReadKey();
        }

        private static Aluno PedirInformacoes()
        {
            Console.Clear();
            Console.Write("Olá, digite o número da matrícula do aluno: ");
            int matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Agora, digite o nome do aluno: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("");

            float[] notas = new float[2];

            for (int c = 0; c < 2; c++)
            {
                Console.Write("Digite a " + (c + 1) + "º nota: ");
                notas[c] = float.Parse(Console.ReadLine()!);
                Console.WriteLine("");
            }

            return new Aluno(matricula, nome, notas);
        }
    }
}