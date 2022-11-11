class StaticConstr
{
    public StaticConstr()
    {
        Console.WriteLine("Конструктор");
    }

    static StaticConstr()           // Вызывается 1 раз за весь период работы программы. Автоматически, или же при первом обращении к классу.
    {
        Console.WriteLine("Статический конструктор");
    }

    public static void Foo()
    {
        Console.WriteLine("Foo");
    }
}