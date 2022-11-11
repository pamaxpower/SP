/* Арифметическое переполнение на примере "Ядерного Ганди"
"Ядерный Ганди" - баг в игре Civilization, когда вдруг мирный Ганди начинал наносить по всем ядерные удары.
*/



byte aggresion = 1;                         // уровень агрессии в игре (мирный Ганди)
byte democratyModifier = 2;                 // бонусный параметр снижающий уровень агрессии на 2 единицы

aggresion = (byte)(aggresion - democratyModifier);      // сужающее преобразование данных
                                                        // произошло переполнение данных через нижнюю границу и на выходе мы получаем не -1, а 255 (ядерный Ганди)

// aggresion = checked((byte)(aggresion - democratyModifier));     // проверка на переполнение (выдаст ошибку)

Console.WriteLine(aggresion);


// Переполнение
int a = int.MaxValue;
a = a + 1;              // переполнение через верхнюю границу   
Console.WriteLine(a);

int b = int.MinValue;
b = b + 1;              // переполнение через нижнюю границу
Console.WriteLine(b);


// Перепоолнение double:
/*
double a = 1.0 / 0.0;
Console.WriteLine(double.IsInfinity(a));                // Проверка на бесконечность: true 
double b = 0.0 / 0.0;
Console.WriteLine(double.IsNaN(b));                     // Проверка на нечисло: true 
double c = double.MaxValue + double.MaxValue;
Console.WriteLine(double.IsInfinity(c));                // Проверка на бесконечность: true 
*/


/* Переполнение decimal - всегда вызывает исключение (ошибку), даже если используется ключевое слово checked
decimal - точный тип данных (применяется в банковской сфере)*/