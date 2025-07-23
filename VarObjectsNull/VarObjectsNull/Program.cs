namespace VarObjectsNull;

using System;
class Program
{
    string none = "Welisson Alysson";
    int meuNumero = 7;
    var nome2 = "Welisson Alysson";
    var variavel = DateTime.Now;
    Console.WriteLine("Hello World!");
    static void Main(string[] args)
    {
        
        Console.WriteLine(none);
        Console.WriteLine(nome2);
        Console.WriteLine(variavel);
        Console.WriteLine(meuNumero);

        // Variável do tipo var não pode ser nula

        int? numeroNulo = null;
        int minhaIdade = numeroNulo.Value;
        bool informouIdade = numeroNulo.HasValue;

        if (informouIdade)
        {
            Console.WriteLine($"Minha idade é {minhaIdade}");
        }
        else
        {
            Console.WriteLine("Você não informou a idade");
        }
    }


}