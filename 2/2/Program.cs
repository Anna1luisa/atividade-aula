using System;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R$ {Preco:F2} | Estoque: {Quantidade} unidades");
    }
}

class Program
{
    static void Main()
    {
        Produto prod = new Produto();
        prod.Nome = "Notebook";
        prod.Preco = 3500.50;
        prod.Quantidade = 10;

        prod.ExibirDados();
    }
}