using System;
using System.Collections.Generic;
using ClassLibrary1; // Referência à biblioteca

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var funcionario = new Funcionario
            {
                Nome = "Julia",
                Cargo = "Analista"
            };

            
            var cliente = new Cliente
            {
                Nome = "Cesar",
                Empresa = "Produtora"
            };

            // Chamando métodos individuais
            funcionario.ExibirInfo();
            cliente.ExibirInfo();

            funcionario.MetodoFinal();
            cliente.MetodoFinal();

            // Lista de polimorfismo
            List<Pessoa> pessoas = new List<Pessoa> { funcionario, cliente };
            Console.WriteLine("\n=== Lista de Pessoas ===");
            foreach (var p in pessoas)
            {
                p.ExibirInfo();
            }

            Console.ReadLine();
        }
    }
}
