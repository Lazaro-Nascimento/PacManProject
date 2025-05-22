using System;
using System.Xml.Serialization;

public class MapaService
{
    internal int[,] Cenario = Mapa.Cenario;
    internal void ShowMap()
    {
        for (int i = 0; i < Cenario.GetLength(0); i++)
        {
            for (int j = 0; j < Cenario.GetLength(1); j++)
            {
                Console.Write($"{Cenario[i, j]}");
            }
            Console.WriteLine();
        }
    }
}