//Crie uma classe chamada “Círculo” que possua um atributo para armazenar o raio e métodos para calcular a área e o 
//perímetro do círculo.

using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite o valor do raio para cálculo do círculo: ");
            var raio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Circulo circulo = new Circulo(raio);

            float area, perimetro;

            area = circulo.CalculoDeArea(raio);
            perimetro = circulo.CalculoDePerimetro(raio);

            Console.WriteLine($"A área do círculo baseado no raio é: {area:n2}\nO perímetro do círculo baseado no raio é: {perimetro:n2}");
            Console.ReadKey();
        }
    }
}