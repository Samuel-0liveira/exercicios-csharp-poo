namespace Exercicio08
{
    class Carro
    {
        public Carro(string marca, string modelo, int velocidadeAtual)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadeAtual { get; set; }

        internal void Acelerar(int velocidade)
        {
            VelocidadeAtual += velocidade;
        }

        internal void Frear(int velocidade)
        {
            if (VelocidadeAtual < velocidade)
            {
                VelocidadeAtual = 0;
            } else {
                VelocidadeAtual -= velocidade;
            }
        }

        internal void ExibirVelocidade()
        {
            Console.WriteLine($"Velocidade atual: {VelocidadeAtual} Km");
            Console.ReadKey();
        }
    }
}