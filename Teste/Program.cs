internal class Program
{
    private string texto;           //exemplos: "ABCD", "1234", "abcd" ou "#$%&/()Çç á à";
    private int numeroInteiro;      //exemplos: 0, 1, 2, 352, 5, 98 ou 4
    private double numeroDecimal;   //exemplos: 3.1415, 1.2 ou 432.9
    private bool variavelBooleana;  //exemplos: true ou false

    private static void Main(string[] args)
    {
        string bomDia = "Bom dia pessoal";
        Console.WriteLine(bomDia);

        Console.WriteLine("Digite primeiro valor: ");
        string primeiroValorEmString = Console.ReadLine();

        Console.WriteLine("Digite segundo valor: ");
        string segundoValorEmString = Console.ReadLine();

        double primeiraNota = double.Parse(primeiroValorEmString);
        double segundaNota = double.Parse(segundoValorEmString);

        double media = (primeiraNota + segundaNota) / 2;

        string mensagemFinal = $"Sua média foi {media} - ";
        if (media > 5)
            mensagemFinal = mensagemFinal + "Passou de ano";
        else if (media == 5)
            mensagemFinal = mensagemFinal + "Recuperação";
        else
            mensagemFinal = mensagemFinal + "Chumbou!!!";

        //Sua nota foi 9.5 - Passou de ano
        //Sua nota foi 4.2 - Chumbou!!!
        Console.WriteLine(mensagemFinal);
        Console.ReadKey();
    }
}