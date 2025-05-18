using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string entradaNomes = Console.ReadLine();
        char letraInicial = Convert.ToChar(Console.ReadLine().ToUpper());

        string[] nomes = entradaNomes.Split(",");
        List<string> nomesEncontrados = new List<string>();

        for (int i = 0; i < nomes.Length; i++) {
            if (nomes[i].ToUpper().TrimStart().StartsWith(letraInicial)) {
                nomesEncontrados.Add(nomes[i].TrimStart());
            }
        }

        if (nomesEncontrados.Count == 0) {
            Console.WriteLine("Nenhum nome encontrado");
        } else {
            foreach (string nome in nomesEncontrados) {
                Console.WriteLine(nome);
            }
        }
    }
}