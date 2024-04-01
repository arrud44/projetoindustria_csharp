using System;
using System.Collections.Generic;

public class FabricaSalgadinho
{
    public string NomeFabrica { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }

    public List<LinhaProducaoSalgadinho> LinhasProducao = new List<LinhaProducaoSalgadinho>();

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da fabrica de salgadinho:");
        Console.WriteLine($"Nome: {NomeFabrica}");
        Console.WriteLine($"Localização: {Localizacao}");
        Console.WriteLine($"Ano de Fundação: {AnoFundacao}");
    }

    public void AdicionarLinhaProducao(LinhaProducaoSalgadinho linhaProducao)
    {
        LinhasProducao.Add(linhaProducao);
    }
}

public class LinhaProducaoSalgadinho
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidade { get; set; }

    public List<MaquinaSalgadinho> Maquinas = new List<MaquinaSalgadinho>();

    public void ExibirDetalhes()
    {
        Console.WriteLine("Detalhes da linha de produção de salgadinho:");
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Capacidade: {Capacidade}");
    }

    public void AdicionarMaquina(MaquinaSalgadinho maquina)
    {
        Maquinas.Add(maquina);
    }
}

public class MaquinaSalgadinho
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public List<ProdutoSalgadinho> Produtos = new List<ProdutoSalgadinho>();

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da maquina de salgadinho:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
    }

    public void IniciarProducao(ProdutoSalgadinho produto)
    {
        Produtos.Add(produto);
    }
}

public class ProdutoSalgadinho
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public double Preco { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Detalhes do salgadinho:");
        Console.WriteLine($"Nome do produto: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco}");
    }

    public void AtualizarPreco(double novoPreco)
    {
        Preco = novoPreco;
        Console.WriteLine($"Este é o novo preço: {Preco}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FabricaSalgadinho fabricaSalgadinho = new FabricaSalgadinho();
        fabricaSalgadinho.NomeFabrica = "Salgadinhos Delícia";
        fabricaSalgadinho.Localizacao = "Campo Largo";
        fabricaSalgadinho.AnoFundacao = 2002;

        fabricaSalgadinho.ExibirInformacoes();
        Console.WriteLine("");

        LinhaProducaoSalgadinho linhaProducao1 = new LinhaProducaoSalgadinho();
        linhaProducao1.Numero = 101;
        linhaProducao1.Tipo = "Salgadinhos de Milho";
        linhaProducao1.Capacidade = 200;
        fabricaSalgadinho.AdicionarLinhaProducao(linhaProducao1);

        linhaProducao1.ExibirDetalhes();

        MaquinaSalgadinho maquinaSalgadinho = new MaquinaSalgadinho();
        maquinaSalgadinho.Id = 1001;
        maquinaSalgadinho.Marca = "Salgmax";
        maquinaSalgadinho.Modelo = "Elétrico";
        linhaProducao1.AdicionarMaquina(maquinaSalgadinho);

        maquinaSalgadinho.ExibirInformacoes();

        ProdutoSalgadinho salgadinhoMilho = new ProdutoSalgadinho();
        salgadinhoMilho.Nome = "Salgadinho de Milho Sabor Queijo";
        salgadinhoMilho.Codigo = 987654;
        salgadinhoMilho.Preco = 5.99;
        maquinaSalgadinho.IniciarProducao(salgadinhoMilho);

        salgadinhoMilho.ExibirDetalhes();
        Console.WriteLine("");

        maquinaSalgadinho = new MaquinaSalgadinho();
        maquinaSalgadinho.Id = 1002;
        maquinaSalgadinho.Marca = "Salgmax";
        maquinaSalgadinho.Modelo = "Mecânico";
        linhaProducao1.AdicionarMaquina(maquinaSalgadinho);

        maquinaSalgadinho.ExibirInformacoes();

        ProdutoSalgadinho salgadinhoChurrasco = new ProdutoSalgadinho();
        salgadinhoChurrasco.Nome = "Salgadinho de Milho Sabor Churrasco";
        salgadinhoChurrasco.Codigo = 765432;
        salgadinhoChurrasco.Preco = 6.99;
        maquinaSalgadinho.IniciarProducao(salgadinhoChurrasco);

        salgadinhoChurrasco.ExibirDetalhes();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        LinhaProducaoSalgadinho linhaProducao2 = new LinhaProducaoSalgadinho();
        linhaProducao2.Numero = 202;
        linhaProducao2.Tipo = "Salgadinhos de Batata";
        linhaProducao2.Capacidade = 300;
        fabricaSalgadinho.AdicionarLinhaProducao(linhaProducao2);

        linhaProducao2.ExibirDetalhes();

        MaquinaSalgadinho maquinaBatata = new MaquinaSalgadinho();
        maquinaBatata.Id = 2001;
        maquinaBatata.Marca = "BatatMax";
        maquinaBatata.Modelo = "Automático";
        linhaProducao2.AdicionarMaquina(maquinaBatata);

        maquinaBatata.ExibirInformacoes();

        ProdutoSalgadinho salgadinhoBatata = new ProdutoSalgadinho();
        salgadinhoBatata.Nome = "Salgadinho de Batata Sabor Bacon";
        salgadinhoBatata.Codigo = 123456;
        salgadinhoBatata.Preco = 4.50;
        maquinaBatata.IniciarProducao(salgadinhoBatata);

        salgadinhoBatata.ExibirDetalhes();
        Console.WriteLine("");

        maquinaBatata = new MaquinaSalgadinho();
        maquinaBatata.Id = 2002;
        maquinaBatata.Marca = "BatatMax";
        maquinaBatata.Modelo = "Manual";
        linhaProducao2.AdicionarMaquina(maquinaBatata);

        maquinaBatata.ExibirInformacoes();

        ProdutoSalgadinho salgadinhoCebola = new ProdutoSalgadinho();
        salgadinhoCebola.Nome = "Salgadinho de Batata Sabor Cebola";
        salgadinhoCebola.Codigo = 987654;
        salgadinhoCebola.Preco = 4.50;
        maquinaBatata.IniciarProducao(salgadinhoCebola);

        salgadinhoCebola.ExibirDetalhes();
        Console.WriteLine("");

        Console.WriteLine("-------------------------------TESTANDO OS MÉTODOS-------------------------------");
        Console.WriteLine("Atualização de preço do salgadinho de milho sabor queijo:");
        salgadinhoMilho.AtualizarPreco(6.99);
        Console.WriteLine("Atualização de preço do salgadinho de batata sabor bacon:");
        salgadinhoBatata.AtualizarPreco(5.25);
    }
}