﻿using System;
using tabuleiro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(?, new Posicao(0, 0));
            tab.colocarPeca(?, new Posicao(1, 3));
            tab.colocarPeca(?, new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
