internal class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }

    public static Jogador Novo(string nome, string nacionalidade, int idade, string posicao) =>
        new(nome, nacionalidade, idade, posicao);
}

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Nome do jogador:");
        string nome = Console.ReadLine();

        Console.WriteLine("Nacionalidade do jogador:");
        string nacionalidade = Console.ReadLine();

        Console.WriteLine("Idade do jogador:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Posição do jogador:");
        string posicao = Console.ReadLine();

        Jogador jogador = Jogador.Novo(nome, nacionalidade, idade, posicao);

        Console.WriteLine("Jogador criado!");
        Console.WriteLine($"Nome: {jogador.Nome}");
        Console.WriteLine($"Nacionalidade: {jogador.Nacionalidade}");
        Console.WriteLine($"Idade: {jogador.Idade}");
        Console.WriteLine($"Posição: {jogador.Posicao}");
    }
}
