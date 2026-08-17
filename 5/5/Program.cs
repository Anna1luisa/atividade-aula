using System;

class Funcionario
{
    public string Nome;
    public string Cargo;
    public double Salario;

    public void CalcularAumento(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Funcionário: {Nome} | Cargo: {Cargo} | Salário Atualizado: R$ {Salario:F2}");
    }
}

class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario();
        func.Nome = "Anna Luisa";
        func.Cargo = "Desenvolvedora C#";
        func.Salario = 4000.00;

        func.CalcularAumento(10); // Aplica 10% de aumento
        func.ExibirDados();
    }
}

