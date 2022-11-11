// Свойства Get / Set


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Point point = new Point();
        //point.SetX(5);
        //int x = point.GetX();

        point.Y = 10;               // Присваиваем значение (set)
        int y = point.Y;            // Возвращаем значение (get)

        //Console.WriteLine(x);
    }
}