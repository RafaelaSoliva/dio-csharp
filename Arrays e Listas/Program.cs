using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos = int.Parse(Console.ReadLine());
        string[] nomesJogos = new string[quantidadeJogos];
       
        for (int i = 0; i < quantidadeJogos; i ++) {
          AdicionarJogo(i, nomesJogos);
        }

        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }


    static void AdicionarJogo(int i, string[] nomesJogos) {
        nomesJogos[i] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomesJogos) {
        string saida = nomesJogos[0];
        
        for (int i = 1; i < quantidadeJogos; i ++) {
          saida = saida + ", " + nomesJogos[i];
        }

        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {saida} ao catalogo.");
    }
}