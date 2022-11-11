// enum (перечисление)

Console.Clear();
/*
while (true)
{
    ConsoleKey key = Console.ReadKey().Key;
    
    int keyCode = (int)key;

    Console.WriteLine($"\tEnum {key}\t Code {keyCode}");

    if (key == ConsoleKey.Enter)
    {
        Console.WriteLine("Вы нажали Enter");
    }
}
*/

DayOfWeek dayOfWeek = DayOfWeek.Monday;

Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));   // получаем тип данных

Console.WriteLine(dayOfWeek);               // проверяем значение dayOfWeek
Console.WriteLine((int)dayOfWeek);          // приводим dayOfWeek к int 
Console.WriteLine((DayOfWeek)3);            // приводим int к DayOfWeek (обратная операция)

DayOfWeek nextDay = GetNextDay(dayOfWeek);
Console.WriteLine(nextDay);


DayOfWeek GetNextDay (DayOfWeek day)
{
    if (day < DayOfWeek.Sunday) return day + 1;
    return DayOfWeek.Monday;
}


enum DayOfWeek :byte                // Создали свой список enum. Если значение не указать, то по умолчанию оно начнется с 0 по списку. 
                                    // Если первое значение указано, то следующие будут +1 по списку
                                    // :byte - присваиваем значение byte переменным внутри списка. По умолчанию int 
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}