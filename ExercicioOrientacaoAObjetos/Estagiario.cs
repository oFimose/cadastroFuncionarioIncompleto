namespace ExercicioOrientacaoAObjetos
{
    public class Estagiario : Funcionario
    {
        public double BolsaAuxilio { get; set; }
        public double ValeTransporte { get; set; }

        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}, Tipo {Tipo}, Salário: R${CalcularSalario}");
        }
    }
}
