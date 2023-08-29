internal class Program
{
    private static void Main(string[] args)
    {
        double valor_por_Km = 1.5;
        double desconto = 12;
        double bandeirada = 2;

        Console.WriteLine("Eu cobro $" + valor_por_Km + " por Km rodado");
        Console.WriteLine("A bandeirada são $" + bandeirada);
        Console.WriteLine("Caso gaste $30 euros ou mais, desconto de $" + desconto);

        string distancia = "Que distância percorreu, em Km?";
        Console.WriteLine(distancia);

        string Km_em_string = Console.ReadLine();
        double Km_em_double = double.Parse(Km_em_string);

        double valor_total = Km_em_double * valor_por_Km + bandeirada;
        double subtotal = Km_em_double * valor_por_Km;

        string fatura = "$" + valor_por_Km +
            " X " + Km_em_double +
            "KMs = " + "$" + subtotal;
        Console.WriteLine(fatura);

        string dois = "bandeirada + $" + bandeirada;
        Console.WriteLine(dois);

        if (valor_total >= 30)
        {
            string valor_total_descontado = "desconto - " + desconto;
            Console.WriteLine(valor_total_descontado);
            valor_total = valor_total - desconto;
        }

        string total = "valor a pagar = $" + valor_total;
        Console.WriteLine(total);
        Console.ReadKey();
    }
}