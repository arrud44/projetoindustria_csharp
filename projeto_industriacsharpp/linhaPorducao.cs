using System;
using System.Collections.Generic;

public class LinhaProducao
{
    public List<Maquina> Maquinas = new List<Maquina>();

    public int Num { get; set; }
    public string TipoLinha { get; set; }
    public int CapacidadeProd { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes linha de produção:");
        Console.WriteLine($"Número: {Num}");
        Console.WriteLine($"Tipo: {TipoLinha}");
        Console.WriteLine($"Capacidade: {CapacidadeProd}");
    }

    public void AdicionarMaquina(Maquina M)
    {
        this.Maquinas.Add(M);
    }
}
