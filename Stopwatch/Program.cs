// Программа для измерения времени выполнения кода, метода, функции, программы

using System.Diagnostics;

Console.Clear();

var sw = new Stopwatch();

sw.Start();                                         // начало счетчика времени
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine(i);
}
sw.Stop();                                          // конец счетчика времени
Console.WriteLine($"Time spend: {sw.ElapsedMilliseconds}");

// sw.Reset();                                      // сбрасывает состояние счетчика времени. Restart = Reset + Start
sw.Restart();                                       // сьрасывает состояние счетчика и запускает новый
System.Threading.Thread.Sleep(1000);
sw.Stop();
Console.WriteLine($"Time spend: {sw.ElapsedMilliseconds}");