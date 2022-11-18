class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintFullName()
    {
        System.Console.WriteLine($"Фамилия: {LastName}\t Имя: {FirstName}");
    }

}