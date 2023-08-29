internal class Program
{
    private string texto;           //exemplos: "ABCD", "1234", "abcd" ou "#$%&/()Çç á à";
    private int numeroInteiro;      //exemplos: 0, 1, 2, 352, 5, -98 ou 4
    private double numeroDecimal;   //exemplos: 3.1415, -1.2 ou 432.9
    private bool variavelBooleana;  //exemplos: true ou false

    //Escrever em tela                          - Console.WriteLine();
    //Ler o que Utilizador escreveu             - Console.ReadLine();
    //Esperar qualquer botão utilizador apertar - Console.ReadKey();

    //Arrays = Listas

    private static void Main(string[] args)
    {
        string[] listaDeNomesDeAlunos = new string[]
        {
            "Anna",         //0
            "Dora",         //1
            "Fátima",       //2
            "Ti Maria",     //3
            "Dinis"         //4
        };

        BuscarDinisNaListaETrocarNomeDoAluno(listaDeNomesDeAlunos);

        string textoNotas = string.Join(
            "\n",
            listaDeNomesDeAlunos
        );
        Console.WriteLine(textoNotas);
        Console.ReadKey();
    }

    private static void BuscarDinisNaListaETrocarNomeDoAluno(string[] listaDeNomesDeAlunos)
    {
        string alunoDinis = "Dinis";
        string novoAlunoBarreto = "Barreto";

        int index = 0;
        while (index < listaDeNomesDeAlunos.Length)
        {
            if (listaDeNomesDeAlunos[index] == alunoDinis)
            {
                listaDeNomesDeAlunos[index] = novoAlunoBarreto;
            }

            index = index + 1;
        }


        for (int indexDoFor = 0; indexDoFor < listaDeNomesDeAlunos.Length; indexDoFor++)
        {
            if (listaDeNomesDeAlunos[indexDoFor] == alunoDinis)
            {
                listaDeNomesDeAlunos[indexDoFor] = novoAlunoBarreto;
            }
        }
        
        
    }
}