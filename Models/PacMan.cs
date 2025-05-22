

internal class PacMan
{
    protected Boolean IsOverPower { get; set; }
    protected Boolean IsAlive { get; set; }
    protected int QtCoinsEaten { get; set; }

    public PacMan()
    {
        IsOverPower = false;
        IsAlive = true;
        QtCoinsEaten = 0;
    }
}