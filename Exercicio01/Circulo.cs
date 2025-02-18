using System.Formats.Asn1;

namespace Exercicio01
{
    public class Circulo
    {
        public Circulo(int raio)
        {
            Raio = raio;
        }
        
        public int Raio { get; set; }

        internal float CalculoDeArea(int raio)
        {
            float area = 0;

            if (raio < 0) {
                Console.WriteLine("Não foi possível calcular a área do círculo, o valor deve ser positivo!");
            } else {
                area = 3.14f * (raio * raio);
            }

            return area;
        }

        internal float CalculoDePerimetro(int raio)
        {
            float perimetro = 0;

             if (raio < 0) {
                Console.WriteLine("Não foi possível calcular o perímetro do círculo, o valor deve ser positivo!");
            } else {
                perimetro = 2 * 3.14f * raio;
            }

            return perimetro;
        }
    }
}