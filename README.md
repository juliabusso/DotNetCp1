# 🖥️ Projeto Console + Biblioteca em C#

## 🎯 Objetivo
Este projeto foi desenvolvido para demonstrar os principais conceitos de **modificadores de acesso**, **herança**, **classe abstrata** e **polimorfismo com override** em C#.  

A solução contém:
- Um projeto **ConsoleApp** (aplicação de console).
- Um projeto **ClassLibrary1** (biblioteca de classes).
- O ConsoleApp utiliza as classes definidas na biblioteca.

---

## 📂 Estrutura do Projeto
Solução
│
├── ConsoleApp # Projeto console (Program.cs)
│
└── ClassLibrary1 # Biblioteca de classes
├── Pessoa.cs # Classe abstrata base
├── Funcionario.cs
└── Cliente.cs

## 🔒 Modificadores de Acesso
Foram implementados **todos os 7 níveis de acesso** dentro da classe `Pessoa`:

1. **public** → acessível por qualquer lugar.  
2. **private** → acessível apenas na própria classe.  
3. **protected** → acessível na classe e em suas herdeiras.  
4. **internal** → acessível apenas dentro do projeto da biblioteca.  
5. **protected internal** → acessível por herança ou dentro do mesmo projeto.  
6. **private protected** → acessível apenas por herança dentro do mesmo projeto.  
7. Uso de **abstract / virtual / override** → demonstrando acesso e polimorfismo.

8. ## ▶️ Execução
Ao executar o ConsoleApp:
- São criados objetos de `Funcionario` e `Cliente`.
- São exibidas as informações de cada um, chamando métodos polimórficos.
- Os modificadores de acesso ficam evidentes dentro da hierarquia das classes.

---

## ✅ Requisitos atendidos
- Estrutura com **Console + Biblioteca**.  
- Implementação dos **7 níveis de acesso**.  
- Uso de **classe abstrata**.  
- Aplicação de **polimorfismo com override**.  
