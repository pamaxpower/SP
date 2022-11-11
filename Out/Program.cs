/*
OUT передается по ссылке. Ведет себя также как ключевое слово Ref
Если мы используем ключевое слово out, то внутри метода мы обязаны присвоить значение переменной, к которой относится модификатор out
- метод с использование ключевого слова out гарантирует изменение значения переменной, даже если она была объявлена и использована раннее
- также новую переменную в коде можно объявить сразу с использование метода: НазваниеМетода(out int a)
- Применение: метод TryParse => int.TryParse(str, out int result) 
*/
/*
IN позовляет передать параметр в метод по ссылке, но в отличии от Ref и Out мы не можем ни изменить ни присвоить значение - read only (только для чтения)
*/
using System;
using System.Diagnostics;

Console.Clear();
static void Bar(in Point value)
{ }

static void Foo(Point value)
{ }

Point a = new Point();

Stopwatch sw = new Stopwatch();

sw.Start();
for (int i = 0; i < int.MaxValue; i++)
{
    Foo(a);
}
sw.Stop();
Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

sw.Restart();
for (int i = 0; i < int.MaxValue; i++)
{
    Bar(a);
}
sw.Stop();
Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");

struct Point                // создали свой тип данных из примитивных типов float - точка в 3D пространстве
{
    public float x;
    public float y;
    public float z;
}
