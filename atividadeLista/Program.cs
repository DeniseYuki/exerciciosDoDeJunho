using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação da lista de strings
        List<string> nomes = new List<string> { "João", "Maria", "Pedro", "Ana" };

        // Ordenando a lista em ordem alfabética
        nomes.Sort();

        // Imprimindo os nomes ordenados
        Console.WriteLine("Nomes em ordem alfabética:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}
