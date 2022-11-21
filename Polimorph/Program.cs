// Полиморфизм

class Car                           // Машина, базовый класс
{
    /*private void StartEngine()        // Будет виден только на уровне базового класса
    {
        Console.WriteLine("Двигатель запущен");
    }*/
    protected virtual void StartEngine()        // Если этот метод сделать virtual, то его можно будет переопределить в классах-наследниках
    {
        Console.WriteLine("Двигатель запущен");
    }
    public virtual void Drive()     // виртуальный метод. virtual создает возможность переопределять методы в классах-наследниках
    {
        StartEngine();
        Console.WriteLine("Я машина, я еду!");
    }
}

class SportCar : Car
{
    public override void Drive()
    {
        // base.Drive();               // Стандартная фича, которая вызывает базовый метод Drive. Если метод полностью переопределяется, то эту строчку писать не надо
        // StartEngine();              // Метод не может вызваться потому что у него модификатор private
        StartEngine();
        Console.WriteLine("Я машина, я еду очень быстро!");
    }

    protected override void StartEngine()
    {
        Console.WriteLine("Э-рон дон дон");
    }


}

class Person                        // Некий человек, который может водить машину
{
    public void Drive(Car car)      // Метод, который параметром принимает объект класса Car и в теле метода использует метод Drive из класса Car
    {
        car.Drive();
    } 
}



class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //Car car = new Car();               // Создаем объект класса Car
        Person person = new Person();      // Создаем объект класса Person
        //person.Drive(car);                 // Человек person может вести машину car
        person.Drive(new Car());           // без переменной - вызывается метод Drive из базового класса
        Console.WriteLine();
        person.Drive(new SportCar());      // вызывается переопределенный метод из класса SportCar



    }
}
