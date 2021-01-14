using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {

        private Tabuleiro tab;
        private int turno;
        private Cor jogadorAtual;

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.
        }
    }
}
