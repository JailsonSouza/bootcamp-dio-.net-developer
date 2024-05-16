using System;

public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    public string nome;
    public string descricao;
    public int poder;
    
    public void Criar (string nome, string descricao, int poder)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        string nome = Console.ReadLine();


        string descricao = Console.ReadLine();


        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico();
        item.Criar(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.nome}\nDescrição: {item.descricao}\nPoder: {item.poder}");
    }
}