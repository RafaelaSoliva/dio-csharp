using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa (string nome, int idade) {
        Nome = nome;
        Idade = idade;
    }

    public void Exibir() {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}


class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        pessoa.Exibir();
    }
}