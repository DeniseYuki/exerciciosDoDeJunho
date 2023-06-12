using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação da lista
        List<int> numeros = new List<int> { 15, 30, 10, 5, 20 };

        // Encontrando o maior valor na lista
        int maiorValor = int.MinValue;
        foreach (int numero in numeros)
        {
            if (numero > maiorValor)
            {
                maiorValor = numero;
            }
        }
        Console.WriteLine("Maior valor na lista: " + maiorValor);

        // Encontrando o menor valor na lista
        int menorValor = int.MaxValue;
        foreach (int numero in numeros)
        {
            if (numero < menorValor)
            {
                menorValor = numero;
            }
        }
        Console.WriteLine("Menor valor na lista: " + menorValor);
    }
}