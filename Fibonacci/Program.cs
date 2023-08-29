internal class Program
{
    private static void Main(string[] args)
    {
        string pergunta = "Quantos termos da sequencia de Fibonacci voce quer?";
        Console.WriteLine(pergunta);
        string quantidade_de_termos_string = Console.ReadLine();
        int quantidade_de_termos = int.Parse(quantidade_de_termos_string);

        int primeiro_termo = 1;
        int segundo_termo = 0;
        int termo_seguinte = 0;

        List<int> termos = new List<int>();
        if (quantidade_de_termos >= 1)
        {
            termos.Add(1);
        }
        while (termos.Count < quantidade_de_termos)
        {
            termo_seguinte = primeiro_termo + segundo_termo;

            segundo_termo = primeiro_termo;
            primeiro_termo = termo_seguinte;

            termos.Add(termo_seguinte);
        };
        Console.WriteLine(string.Join(" , ", termos));

        Console.ReadKey();
    }
}