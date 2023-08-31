internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Por favor insira um número para receber a sua tabuada:");
        string numero_a_calcular_string = Console.ReadLine();
        double numero_a_calcular = double.Parse(numero_a_calcular_string);

        Console.WriteLine("Agora insira o número de vezes que quer que seja repetido");
        string numero_de_vezes_string = Console.ReadLine();
        double numero_de_vezes = double.Parse(numero_de_vezes_string);

        Console.WriteLine("A tabuada deste número é :");

        for (int numero_tabuada = 1; numero_tabuada <= numero_de_vezes; numero_tabuada++)
        {
            double resultado = numero_a_calcular * numero_tabuada;

            Console.WriteLine(" " + numero_a_calcular + " X " + numero_tabuada + " = " + resultado);
        }

        Console.WriteLine("Obrigado por usar esta plataforma");
    }
}