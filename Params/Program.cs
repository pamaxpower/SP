/* используется для методов, где необходимо менять количество принимаемых агрументов (например, нахождение суммы)
- позволяет реализовать метод таким образом, чтобы мы всегда имели возможность передать различное количество параметров
*/
Console.Clear();


int Sum(params int[] parameters)                // по сути на вход мы принимает массив и находим сумму его элементов
{                                               // ключевое слово params позволяет принимать значения через запятую
    int result = 0;

    for (int i = 0; i < parameters.Length; i++)
    {
        result += parameters[i];
    }
    return result;
}

int result = Sum(5,4,1);
Console.WriteLine(result);


/*
void Foo(params object[] par)                   // object включает в себя все типы данных
{
    string message = "Тип данных {0}, значение {1}";
    foreach (var item in par)
    {
        Console.WriteLine(message, item.GetType(), item);       // message выдается в печать, а {0} и {10 принимают значение следующих за сообщением параметров}
        // Console.WriteLine($"Тип данных {item.GetType()}, значение {item}");      // или так
    }
}

Foo("test", 5, 7.12, '2', 5.89f, true);
*/