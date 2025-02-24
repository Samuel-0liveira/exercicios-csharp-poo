namespace Exercicio07
{
    class Triangulo
    {
        public Triangulo(double[] lados)
        {
            Lados = lados;
        }

        public double[] Lados { get; set; }

        internal bool ValidarTriangulo(double[] lados)
        {
            bool valido;

            if (lados[0] < lados[1] + lados[2] && lados[1] < lados[2] + lados[0] && lados[2] < lados[0] + lados[1])
            {
                valido = true;
            } else {
                valido = false;
            }

            return valido;
        }

        internal void CalcularArea(double[] lados)
        {
            if (ValidarTriangulo(lados))
            {
                var semiPerimetro = (lados[0] + lados[1] + lados[2]) / 2;
                var area = semiPerimetro * (semiPerimetro - lados[0]) * (semiPerimetro - lados[1]) * (semiPerimetro - lados[2]);
                area = Math.Sqrt(area);
                Console.WriteLine($"A área do triângulo baseado nos lados passados é: {area:n2}");
            } else {
                Console.WriteLine("Os lados informados não categorizam um triângulo!");
            }
        }
    }
}