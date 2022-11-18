// Синтаксис инициализации классов



class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();          // Создание первого объекта
        person1.FirstName = "Ранд";
        person1.LastName = "алТор";
        
        Address address = new Address();
        address.Country = "Андор";
        address.Region = "Двуречье";
        address.City = "Эмондов Луг";

        person1.Address = address;              // Привязка класса Address к классу Person. Без него объект можно потерять

        Person person2 = new Person             // Инициализация второго объекта
        {
            FirstName = "Мартин",
            LastName = "Дугин",
            Address = new Address
            {
                Country = "Россия",
                Region = "Москва",
                City = "Неизвестно"
            }
        };

    }
}

