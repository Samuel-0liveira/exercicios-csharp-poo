//Implemente uma classe chamada “ContaBancária” que possua atributos para armazenar o número da conta, nome do titular 
//e saldo. Adicione métodos para realizar depósitos e saques.

using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            var conta = PassarInformacoes();

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine($"Número da conta: {conta.NumeroDaConta}");
                Console.WriteLine($"Nome do titular: {conta.Titular}");
                Console.WriteLine($"Saldo atual: {conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao) 
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o valor do depósito R$: ");
                        float deposito = float.Parse(Console.ReadLine()!);
                        conta.Depositar(deposito);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o valor do saque R$: ");
                        float saque = float.Parse(Console.ReadLine()!);
                        conta.Sacar(saque);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo da conta...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ops, opção inválida, verifique e tente novamente!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static ContaBancária PassarInformacoes()
        {
            Console.Clear();

            Console.Write("Por favor, digite o número da conta: ");
            var numeroDaConta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Em seguida, digite o nome do titular da conta: ");
            var nomeTitular = Console.ReadLine()!;
            Console.WriteLine();

            Console.Write("Por fim, digite o saldo inicial da conta: ");
            float saldoInicial = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            if (saldoInicial < 0) {
                saldoInicial = 0;
            }

            return new ContaBancária(numeroDaConta, nomeTitular, saldoInicial);
        }
    }
}