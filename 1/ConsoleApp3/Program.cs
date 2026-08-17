using System;

class Aluno
{
    // Atributos da classe
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Aluno
        Aluno aluno1 = new Aluno();

        // Atribuindo valores aos atributos
        aluno1.Nome = "Anna Luisa";
        aluno1.Idade = 18;
        aluno1.Curso = "Fullstack";

        // Exibindo as informações no console
        Console.WriteLine("--- Informações do Aluno ---");
        Console.WriteLine($"Nome: {aluno1.Nome}");
        Console.WriteLine($"Idade: {aluno1.Idade} anos");
        Console.WriteLine($"Curso: {aluno1.Curso}");
    }
}
