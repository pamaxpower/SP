
class StaticMethods
{
    private static int a;                               // Статическая переменная
    private int b;                                      // Нестатическая переменная

    public static void Foo()                            // Статический метод
    {
        Console.WriteLine("Вызван метод Foo");
        // Bar();                                       // В статическом методе нельзя использовать нестатические методы класса
        a = 5;                                          // В статическом методе мы можем использовать статические поля
        Console.WriteLine(a);
    }

    public void Bar()                                   // Нестатический метод
    {
        Console.WriteLine("Вызван метод Bar");
        // Console.WriteLine(a);                           // Нестатические методы могут использовать статические поля
        // Foo();                                          // также и с методами
    }
}