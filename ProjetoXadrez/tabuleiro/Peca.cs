using ProjetoXadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }
    }
}

