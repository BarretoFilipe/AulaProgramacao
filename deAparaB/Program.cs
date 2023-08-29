internal class Program
{
    private static void Main(string[] args)
    {

        string A = "A";
        string B = "B";

        string C = A;
        

        A = B;
        B = C;
        

        Console.WriteLine("o valor de A = " + A);
        Console.WriteLine("o valor de B = " + B);
    }
}