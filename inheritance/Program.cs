// Наследование

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"Меня зовут: {FirstName}");
    }
}

class Student : Person          // Наследование. Класс Student - наследник класса Person
{
    public void Learn()
    {
        Console.WriteLine("Я учусь!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Person person = new Person { FirstName = "Кей", LastName = "Альтос"};
        PrintFullName(person);
        // Student student = new Student();
        // student.PrintName();
        // student.Learn();                // Метод класса Student, класс Person его не видит
    }

    static void PrintFullName(Person person)
    {
        System.Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
    }
}

