using System;

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;
    public int Mana { get; set; }

    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine("Status:");
        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}

class Program
{
    static void Main()
    {
        var i1 = Console.ReadLine();
        var i2 = Console.ReadLine();
        var i3 = Console.ReadLine();

        Personagem Jogador1 = new Personagem(i1, i2, i3);
        Jogador1.ExibirStatus();
    }
}
