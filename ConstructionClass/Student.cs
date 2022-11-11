class Student
{
    public Student(string lastName, DateTime birthday)                                          // 1 конструктор: минимальный набор параметров: Фамилия, Дата рождения
    {
        this.lastName = lastName;
        this.birthday = birthday;
    }
    public Student(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday)    // 2 конструктор: более подробное описание студента
                                                                            //конструкция this(lastName, birthday) обращается к данным 1 конструктора. В поле этого конструктора их можно не писать
    {
        this.firstName = firstName;
        this.middleName = middleName;
        //this.lastName = lastName;
        //this.birthday = birthday;
    }

    public Student(Student student)         // 3 конструктор: передаем объект класса. Позволяет скопировать из одного объекта студент в другой

    {
        firstName = student.firstName;
        middleName = student.middleName;
        this.lastName = student.lastName;
        birthday = student.birthday;
    }
    public void SetLastName(string lastName)        // устанавливает значение для фамилии
    {
        this.lastName = lastName;
    }

    private string firstName;
    private string middleName;
    private string lastName;
    private DateTime birthday;

    public void Print()
    {
        Console.WriteLine($"Фамилия: {lastName}\nИмя: {firstName}\nОтчество: {middleName}\nДата рождения: {birthday}");
    }
}