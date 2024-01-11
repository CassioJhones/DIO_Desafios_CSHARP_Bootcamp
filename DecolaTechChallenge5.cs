using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public void CalcularDano() => 
        Console.WriteLine($"\n{Nome} atacou e causou {DanoBase * Mana} de dano!\n");
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int mana = int.Parse(Console.ReadLine());
        int atk = int.Parse(Console.ReadLine());
        Subclasse cassio = new Subclasse(nome, mana, atk);
        cassio.CalcularDano();
    }
}
