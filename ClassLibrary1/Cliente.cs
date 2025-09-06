using System;

namespace ClassLibrary1
{
    public class Cliente : Pessoa
    {
        public string Empresa { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Cliente: {Nome}, Empresa: {Empresa}");
        }

        public override void MetodoFinal()
        {
            Console.WriteLine("Método final sobrescrito em Cliente.");
        }
    }
}
