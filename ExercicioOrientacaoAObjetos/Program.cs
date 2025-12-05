namespace ExercicioOrientacaoAObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deveContinuar = true;
            IList<Funcionario> funcionarios = new List<Funcionario>();

            while (deveContinuar)
            {
                Console.WriteLine("Sistema de Cadastro dos Sem Futuro");
                Console.WriteLine("\n1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Listar Funcionário");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Escolha que tipo de funcionário:");
                        Console.WriteLine("\n1 - CLT");
                        Console.WriteLine("2 - Estagiário");
                        Console.WriteLine("3 - Terceirizado");

                        string tipo = Console.ReadLine();


                        switch (tipo)
                        {
                            case "1":
                                Console.Clear();

                                Console.WriteLine("Digite o CPF do funcionário CLT: ");
                                string funcionarioCpf = Console.ReadLine();
                                
                                bool funcionarioJaExiste = funcionarios.Any(f => f.Cpf == funcionarioCpf); 
                                
                                if (funcionarioJaExiste)

                                {
                                    Console.Clear();
                                    Console.WriteLine($"Já existe um funcionário com o CPF {funcionarioCpf}");
                                    break;
                                }

                                Console.WriteLine("Digite o nome do funcionário CLT: ");
                                string funcionarioNome = Console.ReadLine();
                                
                                
                                Console.WriteLine("Qual será o salário base do funcionário CLT?");
                                string salarioStr = Console.ReadLine();

                                double salarioBase;
                                while (!double.TryParse(salarioStr, out salarioBase))
                                {
                                    Console.WriteLine("Valor inválido! Digite o salário novamente."); //transformar os numeros em string
                                    salarioStr = Console.ReadLine();
                                }
                                
                                CLT clt = new CLT(funcionarioNome, funcionarioCpf, salarioBase);
                                
                                funcionarios.Add(clt);

                                Console.WriteLine($"Funcionário {funcionarioNome} cadastrado com sucesso!");
                                break;

                                
                        }
                        break;
                }

            }
        }
    }
}
