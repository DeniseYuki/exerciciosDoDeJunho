namespace exerciciosDoDeJunho;

using System;
using System.Collections.Generic;


// lista não definida, adicionar e remover itens

class Program
{
    static void Main()
    {
        // Criação da lista
        List<int> numeros = new List<int>();

        // Adicionando elementos à lista
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);

        // Imprimindo os elementos da lista
        Console.WriteLine("Elementos da lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Removendo um elemento da lista
        numeros.Remove(20);

        // Imprimindo os elementos atualizados da lista
        Console.WriteLine("\nElementos da lista após remoção:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Verificando se um elemento está na lista
        int elemento = 30;
        if (numeros.Contains(elemento))
        {
            Console.WriteLine($"\n{elemento} está presente na lista.");
        }
        else
        {
            Console.WriteLine($"\n{elemento} não está presente na lista.");
        }

        // Obtendo o índice de um elemento na lista
        int indice = numeros.IndexOf(40);
        Console.WriteLine($"\nO índice do número 40 na lista é: {indice}");

        // Limpando a lista
        numeros.Clear();

        // Verificando se a lista está vazia
        if (numeros.Count == 0)
        {
            Console.WriteLine("\nA lista está vazia.");
        }
    }
}


