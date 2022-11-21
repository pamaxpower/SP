// Абстрактные классы, методы, свойства

abstract class Weapon       // абстрактный класс
{
    public abstract int Damage { get; }    // Абстрактное свойство, которое отвечает за урон оружия. Без возможности изменений извне на уровне экземпляра (без set)
                                                // свойство - это метод, который ведет себя как переменная
    abstract public void Fire();     // абстрактный метод стрельбы из оружия. В нем не может быть реализации
    public void ShowInfo()          // Конкретная реализация метода с помощью которого мы видем тип применяемого оружия
    {

        Console.WriteLine($"{GetType().Name}, урон: {Damage}");      // Вывод типа данных.
    }
}

class Gun : Weapon          // наследник абстрактного класса должен реализовывать все его абстрактные методы
{
    // public override int Damage => throw new NotImplementedException();
    // public override int Damage => 5;
    public override int Damage { get { return 5; } }

    public override void Fire()
    {
        // throw new NotImplementedException();        // Стандартная конструкция, которая показывает ошибку, если мы не реализовали этот метод
        Console.WriteLine("бах-бах!");
    }
}
 class Laser : Weapon
 {
    public override int Damage => 8;
    public override void Fire()
    {
        Console.WriteLine("пиу-пиу!");
    }
 }

 class Bow : Weapon
 {
    public override int Damage { get { return 3; } }
    public override void Fire()
    {
        Console.WriteLine("чпуньк!");
    }
 }


class Player
{
    public void Fire(Weapon weapon)     // При такой реализации класс Player может стрелять из чего угодно, что будет унаследовано от класса Weapon
    {
        weapon.Fire();
    }
    public void CheckInfo(Weapon weapon)    // Проверка информации об оружии
    {
        weapon.ShowInfo();
    }
}

 


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        // Weapon weapon = new Weapon();       // Не удается создать экземпляр абстрактного типа или интерфейса "Player"
        Player player = new Player();
        
        // player.Fire(new Gun());              // объект player стреляет из ружья]
        Weapon[] inventory = { new Gun(), new Laser(), new Bow()};       // Инвентарь с оружием: массив типа Weapon с элементами объектов разных классов

        foreach (var item in inventory)
        {
            player.CheckInfo(item);
            player.Fire(item);
            Console.WriteLine();
        }
    }
}