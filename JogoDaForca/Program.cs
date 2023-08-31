internal class Program
{
    private static void Main(string[] args)
    {
        /*
        pegar a letra do utilizador
        verificar se ela existe na palavra
        se existir coloca no lugar dela
        se não, tira um ponto de chance que o utilizador tem - ele começa com 7 chances
        se completar a palavra, ganha
        se errar mais de 7 vezes perde o jogo

        Letra maiúscula sempre - letra.ToUpper()
        Letra minúscula sempre - letra.ToLower()
        */
        //Console.WriteLine(palavra[i]);

        int vidas = 7;

        string palavra = "banana";

        Console.WriteLine("Olá este é o Jogo da Forca porfavor insira uma letra:");

        while (vidas > 0)
        {
            bool retirar_vida = true;
            string letra_string = Console.ReadLine();

            char letra = char.Parse(letra_string.ToLower());

            Console.WriteLine("Voce inseriu " + letra);

            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra != palavra[i])
                {
                    Console.WriteLine("Não");
                }
                else if (letra == palavra[i])
                {
                    Console.WriteLine(palavra[i]);

                    retirar_vida = false;

                    letra = palavra[i];
                }
            }
            if (retirar_vida == true)
            {
                vidas--;
            };

            Console.WriteLine("Tente denovo");
        }
    }
}