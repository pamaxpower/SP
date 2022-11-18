public class B:A                // Наследник класса A
{
    public B()                  // конструктор ВНУТРИ класса наследника
    {
        Console.WriteLine(publicFiled);             // поле доступно
        //Console.WriteLine(privateFiled);            // поле недоступно
        Console.WriteLine(protectedFiled);          // поле доступно

        Foo();
    }
    public void Bar()
    {
        Foo();
    }
}
