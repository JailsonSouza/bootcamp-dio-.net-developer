using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {   
        return valorAtributo >= valorMinimo && valorAtributo <= valorMaximo ? true : false;
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        bool dentroDoIntervalo = VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
        
        Console.WriteLine(dentroDoIntervalo ? "O valor do atributo está dentro do intervalo especificado" : "O valor do atributo está fora do intervalo especificado");
    }
}