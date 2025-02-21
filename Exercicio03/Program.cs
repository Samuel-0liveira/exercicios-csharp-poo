//Crie uma classe chamada “Retângulo” que possua atributos para armazenar a largura e a altura. 
//Implemente métodos para calcular a área e o perímetro do retângulo.

using System;
using System.Reflection;

namespace Exerciocio03
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = RequisitarInformacoes();
            retangulo.CalculoDeArea(retangulo.Largura, retangulo.Altura);
            retangulo.CalcularPerimetro(retangulo.Largura, retangulo.Altura);
            Console.ReadKey();
        }

        private static Retangulo RequisitarInformacoes()
        {
            Console.Clear();
            Console.Write("Por favor, digite a largura do retângulo para calcular sua área e perímetro: ");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Agora, digite a altura do retângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return new Retangulo(largura, altura);
        }
    }
}