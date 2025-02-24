
namespace Exercicio05
{
    public class Funcionario
    {
        public Funcionario(string nome, float salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome { get; set; }
        public float Salario { get; set; }
        public string Cargo { get; set; }

        internal float CalculoDeSalarioLiquido(float salario, float beneficios = 0.06f)
        {
            float impostos, salarioLiquido, beneficioTotal, descontosTotais;

            if (salario <= 2112f)
            {
                impostos = 0;
            } else if (salario >= 2112.01f && salario <= 2826.65f)
            {
                impostos = 158.40f;
            } else if (salario >= 2826.66f && salario <= 3751.05f)
            {
                impostos = 370.40f;
            } else if (salario >= 3751.06f && salario <= 4664.68f)
            {
                impostos = 651.73f;
            } else {
                impostos = 884.96f;
            }

            beneficioTotal = salario * beneficios;

            descontosTotais = beneficioTotal + impostos;

            salarioLiquido = salario - descontosTotais; 

            return salarioLiquido;
        }
    }
}