using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_21
{
    internal class Jogador
    {
        public int pontuacao;
        private int[] cartas = new int[2]; 
        public Jogador()
        {
            Carta carta = new Carta();
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = carta.cartaAleatoria();
            }
            pontuacao = cartas[0] + cartas[1];
        }

        public int[] GetCartas()
        {
            return cartas;
        }
    }
}
