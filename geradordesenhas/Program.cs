// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string[] opcoesPadrao = { 
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" 
        };
        string[] opcoesComSimbolos = { 
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", 
            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+" 
        };

        Random random = new Random();

        Console.WriteLine("Qual o tamanho da senha?");
        string entradaTamanho = Console.ReadLine();

        Console.WriteLine("Deseja a inclusão de símbolos? (s/n)");
        string entradaSimbolos = Console.ReadLine()?.ToLower();

        if (int.TryParse(entradaTamanho, out int tamanho) && tamanho > 0)
        {
            string[] opcoes = entradaSimbolos == "s" ? opcoesComSimbolos : opcoesPadrao;
            string senha = GerarSenha(opcoes, random, tamanho);
            Console.WriteLine($"Senha gerada: {senha}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido maior que zero.");
        }
    }

    private static string GerarSenha(string[] opcoes, Random random, int tamanho)
    {
        char[] senha = new char[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            senha[i] = opcoes[random.Next(opcoes.Length)][0];
        }
        return new string(senha);
    }
}

