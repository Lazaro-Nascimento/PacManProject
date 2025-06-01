using System;

internal class MainService
{
    MapaService mapaService = new MapaService();
    List<Ghost> ghosts = new List<Ghost>();
    PacMan pacman = new PacMan(13, 10);
    public MainService() {
        Ghost blinky = new Blinky(13, 7);
        ghosts.Add(blinky);
    }
    internal void Play()
    {
        mapaService.ShowMap(pacman, ghosts);
    }
}