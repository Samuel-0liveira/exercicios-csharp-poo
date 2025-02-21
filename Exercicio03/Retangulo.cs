namespace Exerciocio03
{
    public class Retangulo
    {
        public Retangulo(int largura, int altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public int Largura { get; set; }
        public int Altura { get; set; }

        internal void CalculoDeArea(int largura, int altura)
        {
            int area = largura * altura;
            Console.WriteLine($"A área do retângulo é: {area}");
        }

        internal void CalcularPerimetro(int largura, int altura)
        {
            int perimetro = 2 * (largura + altura);
            Console.WriteLine($"O perímetro do retângulo é: {perimetro}");
        }
    }  
}