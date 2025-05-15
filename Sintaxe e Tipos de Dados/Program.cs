using System;

class Program
{
    static void Main(string[] args)
    {
        string email, nome, senha;

        email = Console.ReadLine();
        nome = Console.ReadLine();
        senha = Console.ReadLine();
        
        Console.WriteLine($"{nome}, verifique o email: {email} para ativar.");
    }
}