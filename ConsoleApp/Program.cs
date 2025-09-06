using ClassLibrary1;

class Program
{
    static void Main()
    {
        Pessoa funcionario = new Funcionario
        {
            Nome = "Julia",
            Cargo = "Analista"
        };

        Pessoa cliente = new Cliente
        {
            Nome = "Cesar",
            Empresa = "Desenvolvedor"
        };

        funcionario.ExibirInfo();
        cliente.ExibirInfo();

        funcionario.MetodoFinal();
        cliente.MetodoFinal();

        List<Pessoa> pessoas = new List<Pessoa> { funcionario, cliente };
        foreach (var p in pessoas)
        {
            p.ExibirInfo();
        }
    }
}
