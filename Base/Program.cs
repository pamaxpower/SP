// Ключевое слово base

class Point2D
{
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
        Console.WriteLine("Вызван конструктор класса Point2D");
    }

    public int X { get; set; }
    public int Y { get; set; }

    public void Print2D()
    {
        Console.WriteLine("X:\t" + X);
        Console.WriteLine("Y:\t" + Y);
    }
}

class Point3D : Point2D
{
    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
        Console.WriteLine("Вызван конструктор класса Point3D");
    }

    public int Z { get; set; }

    public void Print3D()
    {
        // base.Print2D();          // запись одинакова. Base можно не использовать
        Print2D();
        Console.WriteLine("Z:\t" + Z);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Point3D point3D = new Point3D(3,4,5);
        point3D.Print3D();

    }
}