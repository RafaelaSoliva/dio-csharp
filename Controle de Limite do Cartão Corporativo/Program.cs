using System;
using System.Collections.Generic;
using System.Linq;

class CartaoCorporativo
{
    private decimal LimiteDoCartao { get; set; }
    private List<decimal> ValoresDasTransacoes { get; set; }

    public CartaoCorporativo (decimal limiteDoCartao) {
        LimiteDoCartao = limiteDoCartao;
        ValoresDasTransacoes = new List<decimal>();
    }

    public void AdicionarTransacao (decimal valorDaTransacao) {
        ValoresDasTransacoes.Add(valorDaTransacao);
    }

    public decimal CalcularTotalDasTransacoes () {
        return ValoresDasTransacoes.Sum();
    }

    public bool LimiteFoiUltrapassado () {
        return (CalcularTotalDasTransacoes() > LimiteDoCartao);
    }

    public void ExibirResumo() {
        Console.WriteLine($"Total gasto: {CalcularTotalDasTransacoes()}");

        if (LimiteFoiUltrapassado()) {
            Console.WriteLine("Limite ultrapassado");
        } else {
            Console.WriteLine("Limite OK");
        }
    }
}


class Program
{
    static void Main()
    {
        decimal limiteDoCartao = decimal.Parse(Console.ReadLine());
        int numeroDeTransacoes = int.Parse(Console.ReadLine());
        decimal valorDaTransacao;

        CartaoCorporativo cartaoCorporativo = new CartaoCorporativo(limiteDoCartao);

        for (int i = 0; i < numeroDeTransacoes; i++) {
            valorDaTransacao = decimal.Parse(Console.ReadLine());
            cartaoCorporativo.AdicionarTransacao(valorDaTransacao);
        }

        cartaoCorporativo.ExibirResumo();
    }
}