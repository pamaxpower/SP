using System;

/* Null-совместимые значимые типы (Nullable)
- делает так чтобы значимые типы имели возможность хранить значение null
- Данные, хранящиеся в используемой базе данных, могут иметь значения null, но на языке c# всем значимым типа должно быть присвоено дефолтное значение.
В таком случае используется Nullable
*/

//string str = null;               // ссылочный тип, значение null присваивается
//DataTime? datetime = null;

Console.Clear();

int? i = null;      
Console.WriteLine(i == null);                   // проверяет на null: True
Console.WriteLine(i.HasValue);                  // проверяет на реальное значение: False
Console.WriteLine(i.GetValueOrDefault());       // если в переменной есть какое-то значение, то будет оно, если нет, то будет дефолтное:  0
Console.WriteLine(i.GetValueOrDefault(3));      // будет дефолтное значение, которое мы указали:  3
Console.WriteLine(i ?? 55);                     // оператор объединения с null()/ Проверяет на null и возвращает указанное значение:  55
//Console.WriteLine(i.Value);                     // извлечь данные: InvalidOperationException

Console.WriteLine();

int? j = 2;
Console.WriteLine(j == null);                   // False
Console.WriteLine(j.HasValue);                  // True
Console.WriteLine(j.GetValueOrDefault());       // 2
Console.WriteLine(j.GetValueOrDefault(3));      // 2
Console.WriteLine(j ?? 55);                     // 2
Console.WriteLine(j.Value);                     // 2
