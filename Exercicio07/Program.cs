//Crie uma classe chamada “Triângulo” com atributos para armazenar os três lados do triângulo. 
//Implemente métodos para verificar se é um triângulo válido e calcular sua área.

using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangulo = InformarLados();
            triangulo.CalcularArea(triangulo.Lados);
        }

        private static Triangulo InformarLados()
        {
            Console.Clear();

            double[] lados = new double[3];

            for (int contador = 0; contador < 3; contador++)
            {
                Console.Write("Digite o " + (contador + 1) +"° lado do triângulo: ");
                lados[contador] = double.Parse(Console.ReadLine()!);
                Console.WriteLine("");
            }

            return new Triangulo(lados);
        }
    }
}