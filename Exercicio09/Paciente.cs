namespace Exercicio09
{
    class Paciente
    {
        public Paciente(string nomePaciente, int idade)
        {
            NomePaciente = nomePaciente;
            Idade = idade;
            ConsultasRealizadas = new List<string>();
        }

        public string NomePaciente { get; set; }
        public int Idade { get; set; }
        public List<string> ConsultasRealizadas { get; set; }

        public void IncluirConsulta(DateTime data, string nomeDoDoutor, string diagnostico)
        {
            string consulta = $"Data: {data:d} - Nome do doutor: {nomeDoDoutor} - Diagnóstico: {diagnostico}";
            ConsultasRealizadas.Add(consulta);
        }

        public void ExibirHistorico()
        {
            foreach(var historico in ConsultasRealizadas)
            {
                Console.WriteLine(historico);
            }
        }
    }
}