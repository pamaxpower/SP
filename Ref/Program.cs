// 
Console.Clear();

void Resize(ref int[] array, int size)                               // меняет размер массива
{
    int[] newArray = new int[size];                                   // создаем массив с новым размером
    for (int i = 0; i < array.Length && i < newArray.Length; i++)     // условие должно быть составным, иначе при уменьшении размера массива выдаст ошибку индекса
        newArray[i] = array[i];                                       // записываем в новый массив значения из старого массива

    array = newArray;                                                 // перезаписываем входной массив
}

void AddFirstElements(ref int[] array, int firstElements)             // добавление элемента в начало массива
{
    int[] newArray = new int[array.Length + 1];
    newArray[0] = firstElements;
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i + 1] = array[i];
    }
    array = newArray;
}
void AddLastElements(ref int[] array, int lastElements)               // добавление элемента в конец массива
{
    int[] newArray = new int[array.Length + 1];
    newArray[array.Length] = lastElements;
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    array = newArray;
}
void AddIndexElements(ref int[] array, int index, int elements)       // добавление элемента массива по указанному индексу
{
    int[] newArray = new int[array.Length + 1];
    newArray[index] = elements;
    for (int i = 0; i < index; i++)
        newArray[i] = array[i];
    for (int i = index; i < array.Length; i++)
        newArray[i + 1] = array[i];
    array = newArray;
}

void DelFirstElements(ref int[] array)                                // удаление элемента в начале массива
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < array.Length - 1; i++)
    {
        newArray[i] = array[i + 1];
    }
    array = newArray;
}
void DelLastElements(ref int[] array)                                 // удаление элемента в конце массива
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < array.Length - 1; i++)
    {
        newArray[i] = array[i];
    }
    array = newArray;
}
void DelIndexElements(ref int[] array, int index)                     // удаление элемента массива по указанному индексу
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < index; i++)
        newArray[i] = array[i];
    for (int i = index; i < array.Length - 1; i++)
        newArray[i] = array[i + 1];
    array = newArray;
}

int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };

// Resize(ref myArray, 5);
// Console.WriteLine(String.Join(",",myArray));

// DelFirstElements(ref myArray, 3);
// DelLastElements(ref myArray);
DelIndexElements(ref myArray, 5);

Console.WriteLine(String.Join(",",myArray));

