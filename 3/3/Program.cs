using System;

class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        Saldo -= valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Titular = "Anna Luisa";
        conta.Saldo = 500.00;

        conta.Depositar(200.00);
        conta.Sacar(50.00);

        Console.WriteLine($"Titular: {conta.Titular} | Saldo Atual: R$ {conta.Saldo:F2}");
    }
}
