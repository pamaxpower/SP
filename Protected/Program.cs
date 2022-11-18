// Модификатор доступа protected

public class A                   // Базовый (родительский) класс
{
    public int publicFiled;
    private int privateFiled;
    protected int protectedFiled;
    
    public A()                  // конструктор ВНУТРИ базового класса
    {
        Console.WriteLine(publicFiled);             // поле доступно
        Console.WriteLine(privateFiled);            // поле доступно
        Console.WriteLine(protectedFiled);          // поле доступно
    }

    public void Foo()           // public метод внутри базового класса
    {
        Console.WriteLine(publicFiled);             // поле доступно
        Console.WriteLine(privateFiled);            // поле доступно
        Console.WriteLine(protectedFiled);          // поле доступно    
    }

}

class Program                   // 
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine(a.publicFiled);             // поле доступно
        //Console.WriteLine(a.privateFiled);            // поле недоступно
        //Console.WriteLine(a.protectedFiled);          // поле недоступно
    
        B b = new B();
        Console.WriteLine(b.publicFiled);             // поле доступно
        //Console.WriteLine(b.privateFiled);            // поле недоступно
        //Console.WriteLine(b.protectedFiled);          // поле недоступно

        b.Foo();                                        // через public метод Foo можно получить доступ к переменным privateFiled и protectedFiled
    }
}