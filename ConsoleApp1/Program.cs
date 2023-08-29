internal class Program
{
    //Console.WriteLine(10 / 5); // resultado
    //Console.WriteLine(10 % 5); // resto da divisão
    private static void Main(string[] args)
    {
        Console.WriteLine("Olá! Esta aplicação indica se cada número intruduzido é par ou impár");
        Console.WriteLine("Quando quiser parar escreva f");
        Console.WriteLine("Introduza os números:");

        List<double> lista_numeros = new List<double>();
        string inserir_numeros_string = "";
        while (inserir_numeros_string != "f")
        {
            inserir_numeros_string = Console.ReadLine();
            if (inserir_numeros_string == "f")
            {
                continue;
            }

            int inserir_numeros;
            if (int.TryParse(inserir_numeros_string, out inserir_numeros))
            {
                if (inserir_numeros > 0)
                {
                    lista_numeros.Add(inserir_numeros);
                }
                else
                {
                    Console.WriteLine("Não aceitamos valores negativos ou zero! Digite outro.");
                }
            }
            else
            {
                Console.WriteLine("Valor incorreto! Digite outro.");
            }
        };

        Console.Clear();
        Console.WriteLine("Seus valores digitados são:");
        for (int index = 0; index < lista_numeros.Count; index++)
        {
            double resto_divisao = lista_numeros[index] % 2;
            if (resto_divisao == 0)
            {
                Console.WriteLine(lista_numeros[index] + " - Par");
            }
            else
            {
                Console.WriteLine(lista_numeros[index] + " - Ímpar");
            }
        }
    }
}