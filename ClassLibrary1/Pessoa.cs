using System;

namespace ClassLibrary1
{
    // Classe abstrata: não pode ser instanciada diretamente
    public abstract class Pessoa
    {
        // 1. public → qualquer um pode acessar
        public string Nome { get; set; }

        // 2. private → só a própria classe usa
        private int Id { get; set; }

        // 3. protected → só Pessoa e classes que herdam podem usar
        protected string Documento { get; set; }

        // 4. internal → acessível apenas dentro do mesmo projeto (ClassLibrary1)
        internal string Nacionalidade { get; set; }

        // 5. protected internal → acessível dentro do mesmo projeto OU por herança
        protected internal string Cidade { get; set; }

        // 6. private protected → só derivadas dentro do mesmo projeto acessam
        private protected int Idade { get; set; }

        // Método abstrato → exige override nas filhas
        public abstract void ExibirInfo();

        // Método virtual → pode ser sobrescrito
        public virtual void MetodoFinal()
        {
            Console.WriteLine($"[Pessoa] Nome: {Nome}");
        }
    }
}
