namespace Jogo_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            int[] cartasDoJogador = jogador.GetCartas();
            int comecoJogo;

            Console.WriteLine("##                       Jogo 21                       ##");
            Console.WriteLine("## Quem chegar mais próximo de 21 sem estourar ganha!! ##");
            Console.WriteLine("#########################################################");

            do
            {
                Console.WriteLine("# Digite 1 para jogar! #");
                comecoJogo = int.Parse(Console.ReadLine());
                if (comecoJogo != 1)
                {
                    Console.WriteLine("Jogo Finalizado!");
                }
                else
                {
                    
                }
            } while (comecoJogo == 1);
            

        }
    }
}
