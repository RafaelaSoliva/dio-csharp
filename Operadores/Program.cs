using System;

class Program
{
    static void Main()
    {
        string titulo, descricao;

        titulo = Console.ReadLine();
        descricao = Console.ReadLine();

        if (descricao.Length > 50) {
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        } else {
            string dataLimite = Console.ReadLine();
            Console.WriteLine($"{descricao} ate {dataLimite}");
        }
    }
}