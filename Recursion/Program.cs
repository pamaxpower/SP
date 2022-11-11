/*
Рекурсивный вывод массива
Сумма элементов массива с помощью рекурсии
Сумма цифр числа с помощью рекурсии
*/
Console.Clear();
/*
int[] myArray = new int[5];

void FillArray(int[] array, int i = 0)                   // Заполнение массива с помощью рекурсии
{
    if (i < array.Length)
    {
        array[i] = new Random().Next(1, 10);
        FillArray(array, i + 1);
    }
}
int SumElements(int[] array, int i = 0)
{
    if (i >= array.Length)
    {
        return 0;
    }
    return array[i] + SumElements(array, i + 1);
}

FillArray(myArray);

Console.WriteLine(String.Join(",", myArray));

Console.WriteLine($"Сумма элементов массива равна: {SumElements(myArray)}");
*/
/* num & 10 - последняя цифра числа
num / 10 - отбросили последнюю цифру */

int SumDigitNum(int num)
{
    if(num/10 == 0) return num; 
    // if (num==0) return 0;
    return SumDigitNum(num/10) + num % 10;
}
int sum = SumDigitNum(245);
Console.WriteLine(sum);
