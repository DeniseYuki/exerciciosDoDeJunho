using System;
using System.Collections.Generic;

class Program {

    static void Main()
    {
        List<int> numero = new List<int> { 15, 25, 36, 99, 2, 3, 55 };

        numero.Sort();

        Console.WriteLine("Numeros em ordem");
        foreach (int ordemNumerica in numero)

        {
            Console.WriteLine(ordemNumerica);
            
        }

    }
}
