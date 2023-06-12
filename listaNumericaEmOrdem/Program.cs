using System;
using System.Collections.Generic;

// lista definida, acrescentar, remover, classificar e achar valor maximo e minimo

class Program {

    static void Main()
    {
        // criei a lista
        List<int> numero = new List<int> { 15, 25, 36, 99, 2, 3, 55 };

        // Adicionar elementos a lista
        numero.Add(20);
        numero.Add(120);
        numero.Add(35);
        numero.Add(1);
        numero.Add(32);
        numero.Add(16);

        // removendo um valor

        numero.Remove(3);

        // remover pelo index

        int indice = 0;

        numero.RemoveAt(indice); // removeu o numero 15 no qual é o indice zero da lista antes de ordenar


        numero.Sort();

        Console.WriteLine("Numeros em ordem");
        int maiorValor = int.MinValue;
        foreach (int ordemNumerica in numero)

        {
            Console.WriteLine(ordemNumerica);
            if(ordemNumerica > maiorValor)
            {
                maiorValor = ordemNumerica;
            }
        }
        Console.WriteLine("\n Maior valor : " + maiorValor);

        int menorValor = int.MaxValue;
        foreach (int ordemNumerica in numero)
        {
            if (ordemNumerica < menorValor)
            {
                menorValor = ordemNumerica;
            }
        }
        Console.WriteLine("\n Menor valor é : " + menorValor);
    }
}
       