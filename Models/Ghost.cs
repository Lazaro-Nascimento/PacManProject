internal class Ghost
{
    public string Name { get; set; }
    public ConsoleColor Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public Ghost(string name, ConsoleColor color, int x, int y)
    {
        Name = name;
        Color = color;
        X = x;
        Y = y;

    }
    public virtual void Move() {
        Console.WriteLine($"{Name} se moveu.");
    }
    public void Draw() {
        Console.ForegroundColor = Color;
        Console.SetCursorPosition(X, Y);
        Console.Write("G");
        Console.ResetColor();
    }
}
