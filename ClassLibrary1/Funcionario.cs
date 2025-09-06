using System;

namespace ClassLibrary1
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Funcionário: {Nome}, Cargo: {Cargo}");
        }

        public override void MetodoFinal()
        {
            Console.WriteLine("Método final sobrescrito em Funcionario.");
        }
    }
}
