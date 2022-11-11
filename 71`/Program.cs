
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        // string str = "test";
        // string result = str ?? string.Empty;                                            // проверка на Null - если null, то строка пустая
        // System.Console.WriteLine("Количество символов в строке: " + result.Length);



        void Foo(int a)
        {
            a = -5;
        }
        void Foo1(ref int a)
        {
            a = -5;
        }

        void Bar(int[] arr)
        {
            arr[0] = -3;
        }
        void Bar1(int[] arr)
        {
            arr = null;
        }
        void Bar2(ref int[] arr)
        {
            arr = null;
        }

        int a = 2;

        Foo(a);                         // переменная передается по значению из a=2
        Console.WriteLine(a);
        Foo1(ref a);                    // переменная передается не по значению, а по ссылке. Не копировали новые данные, а ссылались на данные в методе. a=-5
        Console.WriteLine(a);

        int[] myArray = {1,4,6};
        Bar(myArray);                   // После выполнения метода в переменной myArray значение myArray[0] поменяется на -3 (работаем с данными массива, как значением)
        Bar1(myArray);                  // После выполнения метода в переменной myArray значения не поменяются и останутся 1,4,6 (тк мы работаем с ссылкой на этот массив)
        Bar2(ref myArray);              // После выполнения метода в переменной myArray значение поменяется на null (в этом случае мы работаем с ссылкой, как со значением)
    }
}
