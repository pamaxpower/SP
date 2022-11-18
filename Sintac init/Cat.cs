class Cat
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Cat()
    {

    }
}

// Инициализация котов в Main:

        // Cat cat1 = new Cat();                // Обычная инициализация, когда сначала создаем объект с помощью контруктора, а потом присваиваем параметры
        // cat1.Age = 3;
        // cat1.Name = "Барсик";

        // Cat cat2 = new Cat                   // Инициализируем объект сразу со всеми данными в полях
        // {
        //     Age = 3,
        //     Name = "Барсик",
        // };