using System;
using System.Collections.Generic;

public class Maquina
{
    public List<Produto> Produtos = new List<Produto>();

    public int Identificador { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da Maquina:");
        Console.WriteLine($"ID: {Identificador}");
        Console.WriteLine($"Fabricante: {Fabricante}");
        Console.WriteLine($"Modelo: {Modelo}");
    }

    public void IniciarProducao(Produto produto)
    {
        this.Produtos.Add(produto);
    }
}
