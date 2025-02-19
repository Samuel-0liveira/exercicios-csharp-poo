namespace Exercicio02
{
    public class ContaBancária
    {
        public ContaBancária(int numeroDaConta, string titular, float saldo)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
        }

        public int NumeroDaConta { get; set; }
        public string Titular { get; set; }
        public float Saldo { get; set; }

        internal void Depositar(float deposito)
        {
            Saldo += deposito;
            Console.WriteLine("Depósito efetuado!");
            Console.ReadKey();
        }

        internal void Sacar(float quantidadeDoSaque)
        {
            if (Saldo < quantidadeDoSaque)
            {
                Console.WriteLine("Saque não efetuado, saldo inferior ao valor da retirada!");
                Console.ReadKey();
            } else {
                Saldo -= quantidadeDoSaque;
                Console.WriteLine("Valor sacado com sucesso!");
                Console.ReadKey();
            }
        }
    }
}