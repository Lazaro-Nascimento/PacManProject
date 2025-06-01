internal class PacMan
{
    public int X { get; set; }
    public int Y { get; set; }
    protected Boolean IsOverPower { get; set; }
    protected Boolean IsAlive { get; set; }
    protected int QtCoinsEaten { get; set; }
    public void Move(ConsoleKey key, int[,] mapa) {
        int newX = X;
        int newY = Y;
        switch (key) {
            case ConsoleKey.UpArrow: newY--; break;
            case ConsoleKey.DownArrow: newY++; break;
            case ConsoleKey.LeftArrow: newX--; break;
            case ConsoleKey.RightArrow: newX++; break;
        }
        // 0 vazio
        // 1 parede
        // 2 moeda
        // 3 powerup
        if (mapa[newY, newX] != 1) {
            X = newX;
            Y = newY;
            if (mapa[Y, X] == 2) {
                mapa[Y, X] = 0;
                QtCoinsEaten++;
            }
            if (mapa[Y, X] == 3) {
                mapa[Y, X] = 0;
                IsOverPower = true;
            }
        }
    }

    public PacMan(int x, int y)
    {
        X = x;
        Y = y;
        IsOverPower = false;
        IsAlive = true;
        QtCoinsEaten = 0;
    }
}