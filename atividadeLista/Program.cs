using System;
using System.Collections.Generic;

// lista definida colocar em ordem

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
