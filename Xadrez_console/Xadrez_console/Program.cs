﻿using System;
using tabuleiro;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(t);
        }
    }
}
