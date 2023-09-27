public class InClass
{
    //anything that inherits from struct
    //int, bool, Enum
    //

    public static int Foo(int i)
    {
        return i + 10;
    }

    public static void Bar(Foo f)
    {
        f.X += 10;
    }
}

public class Foo
{
    public int X { get; set; }
}

public class Dice
{
    private Random random;
    private int sides;

    public Dice(int sides)
    {
        this.random = new Random();
        this.sides = sides;
    }
    public int Roll()
    {
        return random.Next(1, this.sides);
    }
}
