using System;

namespace ClassLibrary1
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        // Polimorfismo 
        public override void ExibirInfo()
        {
            Console.WriteLine($"[FUNCIONÁRIO] Nome: {Nome}, Cargo: {Cargo}");
        }

        // ninguém além do funcionario pode sobrescrever
        public sealed override void MetodoFinal()
        {
            Console.WriteLine("[Funcionario] Método final (sealed) executado.");
        }
    }
}
