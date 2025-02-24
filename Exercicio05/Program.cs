//Crie uma classe chamada “Funcionário” com atributos para armazenar o nome, o salário e o cargo do funcionário. 
//Implemente métodos para calcular o salário líquido, considerando descontos de impostos e benefícios.

using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = PedirInformacoes();

            Console.Clear();
            Console.WriteLine($"O nome do funcionário: {funcionario.Nome}");
            Console.WriteLine($"Seu cargo: {funcionario.Cargo}");
            Console.WriteLine($"Salário bruto: {funcionario.Salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
            Console.WriteLine($"Salário líquido: {funcionario.CalculoDeSalarioLiquido(funcionario.Salario).ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
            Console.ReadKey();
        }

        private static Funcionario PedirInformacoes()
        {
            Console.Clear();
            Console.Write("Olá, digite o nome do funcionário: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Agora, digite o salário bruto dele(a) R$: ");
            float salario = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Por fim, informe o cargo: ");
            string cargo = Console.ReadLine()!;
            Console.WriteLine("");

            return new Funcionario(nome, salario, cargo);
        }
    }
}