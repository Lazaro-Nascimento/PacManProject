using System;
using System.Collections.Generic;

public class MapaService {
    internal int[,] Cenario = Mapa.Cenario;

    internal void ShowMap(PacMan pacman, List<Ghost> fantasmas) {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < Cenario.GetLength(0); i++) {
            for (int j = 0; j < Cenario.GetLength(1); j++) {
                if (pacman.X == j && pacman.Y == i) {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\u15E7"); // Pac-Man
                    Console.ResetColor();
                    continue;
                }

                var fantasmaAqui = fantasmas.Find(f => f.X == j && f.Y == i);
                if (fantasmaAqui != null) {
                    Console.ForegroundColor = fantasmaAqui.Color;
                    Console.Write("\u2a40");
                    Console.ResetColor();
                    continue;
                }

                // Caso contrário, imprime o que tem no cenário
                switch (Cenario[i, j]) {
                    case 0: Console.Write(" "); break;
                    case 1: Console.Write("█"); break;
                    case 2: Console.Write("·"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¤");
                        Console.ResetColor();
                        break;
                    default: Console.Write("?"); break;
                }
            }
            Console.WriteLine();
        }
    }
}
