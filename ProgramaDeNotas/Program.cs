internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Digite o nome do Aluno:

        Insira a nota do aluno, caso não queira mais inserir notas, digite 'n'

        Numero de Notas =
        Total de Notas =
        Média =
        */
        List<double> notas = new List<double>();

        string Pedir_Nome_do_Aluno = "Óla, por favor, insira o nome do aluno:";
        Console.WriteLine(Pedir_Nome_do_Aluno);

        string Nome = Console.ReadLine();

        string Insira_as_notas = "Obrigado, " + Nome + ", por favor, insere as tuas notas abaixo e quando quiseres parar escreve n e clica enter.";
        Console.WriteLine(Insira_as_notas);

        string nota_string = "";

        while (nota_string != "n")
        {
            nota_string = Console.ReadLine();

            if (nota_string != "n")
            {
                double nota = double.Parse(nota_string);
                notas.Add(nota);
            }
        }
        string Numero_de_Notas = "Voçe inseriu " + notas.Count + " notas";
        Console.WriteLine(Numero_de_Notas);

        double Valor_Total = 0;

        for (int index = 0; index < notas.Count; index++)
        {
            Valor_Total = Valor_Total + notas[index];
        }

        string Total_das_Notas = "No total você teve " + Valor_Total + ".";
        Console.WriteLine(Total_das_Notas);

        double conta_da_media = Math.Round(Valor_Total / notas.Count, 2);

        string Media = "A sua média deu " + conta_da_media + ".";
        Console.WriteLine(Media);
        Console.ReadKey();
    }
}