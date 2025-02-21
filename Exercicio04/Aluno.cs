namespace Exercicio04
{
    public class Aluno
    {
        public Aluno(int matricula, string nome, float[] notas)
        {
            Matricula = matricula;
            Nome = nome;
            Notas = notas;
        }

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public float[] Notas { get; set; }

        internal float CalcularMedia(float[] notas)
        {
            float media = 0;

            if (notas[0] < 0 || notas[1] < 0)
            {
                Console.WriteLine("Não foi possível calcular a média pois um dos valores é negativo.");
                Console.ReadKey();
            } else {
                media = (notas[0] + notas[1]) / 2;
            }

            return media;
        }

        internal string Aprovacao(float media)
        {
            string foiAprovado;

            if (media >= 6)
            {
                foiAprovado = "Aluno aprovado!";
            } else {
                foiAprovado = "Aluno reprovado!";
            }

            return foiAprovado;
        }
    }
}