using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int quantidadeDados = int.Parse(Console.ReadLine());

        List<int> dados = new List<int>();
        int entrada;

        for (int i = 0; i < quantidadeDados; i++) {
            entrada = int.Parse(Console.ReadLine());

            if (entrada > 0) {
                dados.Add(entrada);
            }
        }

        if (dados.Count == 0) {
            Console.WriteLine("Sem despesas validas");
        } else {
            foreach (int dado in dados) {
                Console.WriteLine(dado);
            }
        }
    }
}