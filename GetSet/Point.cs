class Point
{
    private int x;

    public void SetX(int x)    // Установка значения
    {
        this.x = x;
    }

    public int GetX()     // Получаем доступ к полю нашего класса
    {
        return x;
    }

    // используем сниппет propfull + tab
    private int y;              // Вводится переменная
    public int Y                // Для нее определяются свойства под названием Y
    {
        get { return y; }       // Возврат значения;
        set { y = value; }      // Присваивание значения value;
    }
    // Автоматические свойства
    // используем сниппет prop
    public int Z { get; set; }
    

}


