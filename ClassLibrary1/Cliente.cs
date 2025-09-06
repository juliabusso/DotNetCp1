using System;

namespace ClassLibrary1
{
    public class Cliente : Pessoa
    {
        
        public string Empresa { get; set; }

        // Polimorfismo
        public override void ExibirInfo()
        {
            Console.WriteLine($"[CLIENTE] Nome: {Nome}, Empresa: {Empresa}");
        }

        public override void MetodoFinal()
        {
            Console.WriteLine("[Cliente] Método final executado.");
        }
    }
}
