namespace ExercicioOrientacaoAObjetos
{
    public class Terceirizado : Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas + ValorHora;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}, Tipo {Tipo}, Salário: R${CalcularSalario()} Tipo: {Tipo}");
        }
    }
}