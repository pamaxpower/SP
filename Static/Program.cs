// Static


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // StaticMethods myStatic = new StaticMethods();
        // myStatic.Bar();                              // вызывается на уровне экземпляра класса
        // myStatic.Foo();                              // Нельзя получить доступ через ссылку на экземпляр. Статические методы не дотсупны на уровне экземпляра класса
        // StaticMethods.Foo();                         // обратиться к нему можно напряму через класс
    
        // MyClass myClass1 = new MyClass();
        // MyClass myClass2 = new MyClass();
        // // MyClass.Counter = -100;                      // чтобы избежать ошибки присваивания, нужно перед сеттером в методе поставить private
        // Console.WriteLine(MyClass.Counter);             // реализация на примере работы со статическbм свойством
        // Console.WriteLine(MyClass.GetCounter());        // реализация через статический метод

        StaticConstr obj1 = new StaticConstr();
        new StaticConstr();
        new StaticConstr();
        new StaticConstr();
    
    }
}