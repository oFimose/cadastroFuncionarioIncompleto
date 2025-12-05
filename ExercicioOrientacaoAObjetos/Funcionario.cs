namespace ExercicioOrientacaoAObjetos
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TipoFuncionario Tipo { get; set; }


        public Funcionario(string nome, string cpf, TipoFuncionario tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
        }

        public abstract double CalcularSalario(); 
        public abstract void ExibirDados();
    }
}
