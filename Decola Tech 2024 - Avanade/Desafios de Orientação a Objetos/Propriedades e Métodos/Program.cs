using System;

class Robo
{
    public int VelocidadeAtual { get; set; }
    public int VelocidadeMinima { get; set; }
    public int VelocidadeMaxima { get; set; }

    public Robo (int velocidadeMinima, int velocidadeMaxima) {
        VelocidadeAtual = velocidadeMinima;
        VelocidadeMinima = velocidadeMaxima;
        VelocidadeMaxima = velocidadeMaxima;
    }

    public void Acelerar() {
        VelocidadeAtual++;
    }
    
    public void Desacelerar() {
        VelocidadeAtual--;
    }
}


class Program
{
    static void Main()
    {
        string entradaVelocidades = Console.ReadLine();
        string[] valores = entradaVelocidades.Split(" ");

        int velocidadeMinima = int.Parse(valores[0]);
        int velocidadeMaxima = int.Parse(valores[1]);

        Robo robo = new Robo(velocidadeMinima, velocidadeMaxima);

        string entradaComandos = Console.ReadLine();
        char[] comandos = entradaComandos.ToCharArray();

        foreach (char comando in comandos)
        {
            if (comando == 'A') {
                robo.Acelerar();
            }
            else if (comando == 'D') {
                robo.Desacelerar();
            }
        }

        Console.WriteLine(robo.VelocidadeAtual);
    }
}