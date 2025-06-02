using System;

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; }
    public int Vida { get; set; }

    public Personagem (string nome, string raca, string classe) {
        Nome = nome;
        Raca = raca;
        Classe = classe;
        Nivel = 1;
        Vida = 10;
    }

    public void ExibirStatus() {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Raça:{Raca}");
        Console.WriteLine($"Classe:{Classe}");
        Console.WriteLine($"Nível:{Nivel}");
        Console.WriteLine($"Vida:{Vida}");
    }
}


class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);

        Console.WriteLine("Status:");
        personagem.ExibirStatus();
    }
}