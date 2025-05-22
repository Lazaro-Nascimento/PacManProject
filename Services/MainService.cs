using System;

internal class MainService
{
    MapaService mapaService = new MapaService();
    internal void Play()
    {
        mapaService.ShowMap();
    }
}