using System;
using System.Collections.Generic;

public class LinhaDeProducao
{
    public string NomeLinha { get; set; }
    public int Numero { get; set; }
    
    public LinhaDeProducao(string nome, int numero)
    {
        NomeLinha = nome;
        Numero = numero;
    }
}

public class Fabrica
{
    public string NomeFabrica { get; set; }
    public string Local { get; set; }
    public int AnoDeFundacao { get; set; }
    
    public List<LinhaDeProducao> LinhasDeProducao = new List<LinhaDeProducao>();
    
    public void MostrarInformacoes()
    {
        Console.WriteLine("Informações da Fabrica:");
        Console.WriteLine($"Nome: {NomeFabrica}");
        Console.WriteLine($"Localização: {Local}");
        Console.WriteLine($"Ano de Fundação: {AnoDeFundacao}");
    }
    
    public void AdicionarLinhaDeProducao(LinhaDeProducao linha)
    {
        LinhasDeProducao.Add(linha);
    }
}
