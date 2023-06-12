using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite o nome da pessoa amada:");
        string nome = Console.ReadLine();
        Console.Clear();
        string mensagem = GerarMensagemDiaDosNamorados(nome);
        Console.WriteLine(mensagem);
    }

    static string GerarMensagemDiaDosNamorados(string nome)
    {

        string mensagem = $"Olá {nome}! Feliz Dia dos Namorados!Te amo muito!❤";
        

        Console.WriteLine("\n      ***        ***     ");
        Console.WriteLine("    **    **    **   **   ");
        Console.WriteLine("   **       ****      **   ");
        Console.WriteLine("   **        **       **   ");
        Console.WriteLine("   **         *       **   ");
        Console.WriteLine("    **               **   ");
        Console.WriteLine("      **            **   ");
        Console.WriteLine("        **        **     ");
        Console.WriteLine("          **    **       ");
        Console.WriteLine("             **         \n");
        return mensagem;

        
    }
}
