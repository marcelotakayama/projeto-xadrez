using System;
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
                    Console.WriteLine("Turno: " + partida.turno);
                    Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoiesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoiesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.realizaJogada(origem, destino);

                }

                Tela.imprimirTabuleiro(partida.tab);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
