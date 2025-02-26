//Crie uma classe chamada “Paciente” que possua atributos para armazenar o nome, a idade e o histórico de consultas de 
//um paciente. Implemente métodos para adicionar uma nova consulta ao histórico e exibir as consultas realizadas.

using System;
using System.Data;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = PedirInfo();

            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine($"Paciente: {paciente.NomePaciente}");
                Console.WriteLine($"Idade do paciente: {paciente.Idade}");
                Console.WriteLine("");

                Console.WriteLine("1 - Exibir histórico");
                Console.WriteLine("2 - Adicionar consulta ao histórico");
                Console.WriteLine("0 - Sair");
                Console.Write("O que deseja fazer?: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch (opcao)
                {
                    case 1:
                        paciente.ExibirHistorico();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite a data em que ocorreu a consulta (no formato xx/xx/xx): ");
                        DateTime dataConsulta = DateTime.Parse(Console.ReadLine()!);
                        Console.WriteLine("");

                        Console.Write("Informe o nome do doutor que atendeu o paciente: ");
                        string doutor = Console.ReadLine()!;
                        Console.WriteLine("");

                        Console.Write("Por fim, informe o diagnóstico do paciente: ");
                        string diagnostico = Console.ReadLine()!;
                        Console.WriteLine("");

                        paciente.IncluirConsulta(dataConsulta, doutor, diagnostico);
                        Console.WriteLine("Consulta salva no histórico!");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static Paciente PedirInfo()
        {
            Console.Clear();

            Console.Write("Informe o nome do paciente: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Agora informe a idade do paciente: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return new Paciente(nome, idade);
        }
    }
}