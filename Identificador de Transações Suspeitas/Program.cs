using System;
using System.Collections.Generic;
using System.Linq;

class AnalisadorDeTransacoes
{
    private decimal ValorLimite { get; set; }
    private List<decimal> ListaDeTransacoesSuspeitas { get; set; }

    public AnalisadorDeTransacoes(decimal valorLimite) {
        ValorLimite = valorLimite;
        ListaDeTransacoesSuspeitas = new List<decimal>();
    }

    public void AnalisarTransacao (decimal valorDaTransacao) {
        if (valorDaTransacao > ValorLimite) {
            ListaDeTransacoesSuspeitas.Add(valorDaTransacao);
        }
    }

    public void ExibirRelatorio() {
        if (ListaDeTransacoesSuspeitas.Count == 0) {
            Console.WriteLine("Nenhuma transação suspeita");
        } else if (ListaDeTransacoesSuspeitas.Count == 1) {
            Console.WriteLine($"Transacoes suspeitas: {ListaDeTransacoesSuspeitas.Sum()}");
            Console.WriteLine($"{ListaDeTransacoesSuspeitas.Count} transacao suspeita");
        } else {
            Console.WriteLine($"Transacoes suspeitas: {ListaDeTransacoesSuspeitas.Sum()}");
            Console.WriteLine($"{ListaDeTransacoesSuspeitas.Count} transacoes suspeitas");
        }
    }
}


class Program
{
    static void Main()
    {
        decimal valorLimite = decimal.Parse(Console.ReadLine());
        int numeroTransacoesParaAnalisar = int.Parse(Console.ReadLine());
        decimal valorDaTransacao;

        AnalisadorDeTransacoes analisadorDeTransacoes = new AnalisadorDeTransacoes(valorLimite);

        for (int i = 0; i < numeroTransacoesParaAnalisar; i++) {
            valorDaTransacao = decimal.Parse(Console.ReadLine());
            analisadorDeTransacoes.AnalisarTransacao(valorDaTransacao);
        }

        analisadorDeTransacoes.ExibirRelatorio();
    }
}