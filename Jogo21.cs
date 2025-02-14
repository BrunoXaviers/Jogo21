using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_21
{
    internal class Jogo21
    {
        public static void logicaJogo()
        {
            Jogador jogo = new Jogador();
            int jogador = jogo.pontuacao;
            int computador = jogo.pontuacao;
            Console.WriteLine(jogador + " " + computador);
        }
        

    }
}
