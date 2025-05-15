using System;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double quilometrosDiarios = double.Parse(Console.ReadLine());
        int horasDeEletronicosDiarias = int.Parse(Console.ReadLine());
        int refeicoesComCarneDiarias = int.Parse(Console.ReadLine());

        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosDiarios, horasDeEletronicosDiarias, refeicoesComCarneDiarias);
        
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }


    static double CalcularPegadaDeCarbono(double quilometrosDiarios, int horasDeEletronicosDiarias, int refeicoesComCarneDiarias) {
        double carbonoPorTransporte = (quilometrosDiarios * 365 * 0.2);
        double carbonoPorEletronicos = (horasDeEletronicosDiarias * 0.1);
        double carbonoPorConsumoDeCarne = (refeicoesComCarneDiarias * 0.5);
        return (carbonoPorTransporte + carbonoPorEletronicos + carbonoPorConsumoDeCarne);
    }
}