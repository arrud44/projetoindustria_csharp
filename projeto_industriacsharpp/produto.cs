using System;

public class Produto
{
    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do produto:");
        Console.WriteLine($"Nome do produto: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco}");
    }

    public void AtualizarPreco(double novoPreco)
    {
        Preco = novoPreco;
        Console.WriteLine($"Este é o novo preço: {Preco}");
    }

    public string Nome { get; set; }
    public int Codigo { get; set; }
    public double Preco { get; set; }
}
