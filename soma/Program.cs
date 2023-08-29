internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Este programa calcula a soma de dois números.");
        Console.WriteLine("Digita o primeiro número a adiocionar:");
        string primeiro_numero_string = Console.ReadLine();
        double primeiro_numero = double.Parse(primeiro_numero_string);

        Console.WriteLine("Digita o segundo número a adiocionar:");

        string segundo_numero_string = Console.ReadLine();
        double segundo_numero = double.Parse(segundo_numero_string);

        double soma = primeiro_numero + segundo_numero ;

        Console.WriteLine("A soma dos dois números é " + soma);

        Console.ReadKey();

    
    
    
    
    }   
     
}