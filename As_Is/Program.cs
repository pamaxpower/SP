// Операторы As и Is

class Point // : Object
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine("X:\t" + X);
        Console.WriteLine("Y:\t" + Y);
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        Console.Clear();

        object obj = new Point { X = 3, Y = 5 };                // Неявное приведение типов. Создаем типа базового класса и присваиваем тип наследника
        object obj2 = "Hello world";                            // 

        //Point point = (Point)obj;                           // Явное преобразование типов
        //point.Print();

        Foo(obj);           // X = 3, Y = 5
        Foo(obj2);          // null

        Bar(obj);           // X = 3, Y = 5
        Bar(obj2);          // null
    }

    static void Foo(object obj)         // Оператор as 
    {
        Point point = obj as Point;
        if (point != null)
        {
            point.Print();
        }
    }
    static void Bar(object obj)         // Оператор is 
    {
        if (obj is Point point)
        {
            point.Print();
        }
    }
}
