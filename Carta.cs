using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_21
{
    internal class Carta
    {
        public int cartaAleatoria ()
        {
            Random rnd = new Random ();
            return rnd.Next (1, 11);
        }
    }
}
