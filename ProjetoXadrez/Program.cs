﻿using System;
using tabuleiro;
using xadrez;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez {
    class Program {
        static void Main(string[] args) {
           
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                }

                Tela.imprimirTabuleiro(partida.tab);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
