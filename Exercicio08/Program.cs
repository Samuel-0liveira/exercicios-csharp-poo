//Implemente uma classe chamada “Carro” com atributos para armazenar a marca, o modelo e a velocidade atual do carro. 
//Adicione métodos para acelerar, frear e exibir a velocidade atual.

using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = InformacoesDoCarro();
            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine(carro.Marca);
                Console.WriteLine(carro.Modelo);
                Console.WriteLine("");
                Console.WriteLine("1 - Acelerar");
                Console.WriteLine("2 - Frear");
                Console.WriteLine("3 - Exibir velocidade");
                Console.WriteLine("0 - Sair");
                Console.Write("O que deseja fazer?: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o quanto você quer acelerar: ");
                        int velocidade = Convert.ToInt32(Console.ReadLine());
                        carro.Acelerar(velocidade);
                        Console.WriteLine("Acelerando...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Digite o quanto você quer frear: ");
                        velocidade = Convert.ToInt32(Console.ReadLine());
                        carro.Frear(velocidade);
                        Console.WriteLine("Freando...");
                        Console.ReadKey();
                        break;
                    case 3:
                        carro.ExibirVelocidade();
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

        private static Carro InformacoesDoCarro()
        {
            Console.Clear();

            Console.Write("Informe a marca do carro: ");
            string marca = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Informe o modelo do carro: ");
            string modelo = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Informe a velocidade atual do carro: ");
            int velocidadeAtual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return new Carro(marca, modelo, velocidadeAtual);
        }
    }
}