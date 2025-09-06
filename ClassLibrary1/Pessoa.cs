using System;

namespace ClassLibrary1
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public abstract void ExibirInfo();

        public virtual void MetodoFinal()
        {
            Console.WriteLine("Método base executado.");
        }
    }
}
