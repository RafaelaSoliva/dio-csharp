using System;

class minhaClasse
{
    static void Main(string[] args)
    {
        int quantidadeNumeros = int.Parse(Console.ReadLine());
        string entradaNumeros = Console.ReadLine();

        string[] arrayNumeros = entradaNumeros.Split(" ");
        int[] numeros = new int[quantidadeNumeros];

        for (int i = 0; i < quantidadeNumeros; i++) {
            numeros[i] = int.Parse(arrayNumeros[i]);
        }

        int multiplosDeDois = 0;
        int multiplosDeTres = 0;
        int multiplosDeQuatro = 0;
        int multiplosDeCinco = 0;

        foreach (int numero in numeros) {
            if (numero % 2 == 0) {
                multiplosDeDois++;
            }

            if (numero % 3 == 0) {
                multiplosDeTres++;
            }

            if (numero % 4 == 0) {
                multiplosDeQuatro++;
            }

            if (numero % 5 == 0) {
                multiplosDeCinco++;
            }
        }

        Console.WriteLine($"{multiplosDeDois} Multiplo(s) de 2");
        Console.WriteLine($"{multiplosDeTres} Multiplo(s) de 3");
        Console.WriteLine($"{multiplosDeQuatro} Multiplo(s) de 4");
        Console.WriteLine($"{multiplosDeCinco} Multiplo(s) de 5");
    }
}