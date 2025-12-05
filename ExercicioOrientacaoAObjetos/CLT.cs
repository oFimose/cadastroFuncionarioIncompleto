namespace ExercicioOrientacaoAObjetos
{
    public class CLT : Funcionario
    {
        public double SalarioBase {  get; set; }
        
        public CLT(string nome, string cpf, double salario) : base(nome, cpf, TipoFuncionario.CLT) 
        {
            SalarioBase = salario;
        }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}, Tipo {Tipo}, Salário: R${SalarioBase}" );
        }

    }
    
}
