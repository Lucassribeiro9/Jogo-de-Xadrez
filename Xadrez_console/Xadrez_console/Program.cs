﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 0));
            Tela.ImprimirTabuleiro(tab);

            }
            catch (TabuleiroException err)
            {

                Console.WriteLine(err.Message);
            }
        }
    }
}
