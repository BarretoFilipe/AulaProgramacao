internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Por favor, insira um número maior que um para saber se ele é primo ou não:");

        string numero_string = Console.ReadLine();
        int numero = int.Parse(numero_string);

        /*  while (numero_Double < 1)
          {
              if (int.TryParse(numero_string, out numero))
              {
                  if (numero < 1)
                  {
                      Console.WriteLine("Não aceitamos valores menores do que um! Digite outro valor");
                      Console.ReadKey();
                      Console.Clear();
                      Console.WriteLine("Por favor, insira um número maior que um para saber se ele é primo ou não:");
                  }
              }
          }*/

        if (numero == 1)
        {
            Console.WriteLine("Por convenção o número 1 nem é primo nem composto.");
        }
        else if (numero == 2)
        {
            Console.WriteLine("Primo");
        }
        else if (numero % 2 == 0)
        {
            Console.WriteLine("Não primo");
        }
        else
        {
            bool ehNumeroPrimo = true;
            for (int i = 3; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    ehNumeroPrimo = false;
                }
            }

            if (ehNumeroPrimo )
            {
                Console.WriteLine("Primo");
            }
            else
            {
                Console.WriteLine("Não primo");
            }
        }

        // Console.WriteLine("O numero que você inseriu é:");
    }
}