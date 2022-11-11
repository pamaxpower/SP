﻿/* Конструктор класса
- специальный метод класса, который вызывается при создании (объекта) этого класса (используется с ключевым словом new) new Gun() - Gun() и есть конструктор класса
- у любого класса есть свой конструктор по умолчанию

сниппет ctor  позволяет сгенерировать конструктор


// Конструктор по умолчанию 
public Program()            // модификатор только public, иначе его нельзя будет использовать
{
                            // в теле конструктора можно писать условие, которое будет выполняться при создании нового класса
                            // в теле конструктора можно использовать не только переменные этого класса, но и методы
}

public Program(Parameters)  // также внутри конструктора мы можем принимать параметры, тогда и в момент вызова надо указывать этот параметр
{
    
}
 Перегрузка конструкторов класса

- если мы не писали конструктор класса сама, то он все равно есть по умолчанию
- если же мы написали свой конструктор, то конструктор по умолчанию пропадает. Чтобы использовать дефолтный конструктор (с пустыми параметрами) его надо заново создать
Благодаря перегрузке мы можем сконструировать один и тот же объект классса по-разному
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Student student1 = new Student("Иванов", "Иван", "Иванович", new DateTime(2000,10,5));        // Вызывается 2 конструктор
        //Student student1 = new Student("Петров", new DateTime(2000,10,5));                         // Вызывается 1 конструктор
        //Student student2 = student1;
        //Student student2 = new Student(student1);           // Чтобы этого избежать применяют другой контруктор
        //student1.SetLastName("Сидоров");                    // Меняя фамилию первому студенту, она поменяется и у второго, тк обе переменные ссылочные, и ссылаются на один тип данных.
        
        student1.Print();
        
        //student2.Print();
        Console.ReadLine();
    }
}