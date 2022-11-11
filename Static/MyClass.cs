class MyClass
{
    private static int counter;
    public static int Counter
    {
        get { return counter; }
        private set { counter = value; }
    }
    
    public MyClass()
    {
        counter++;
    }

    public static int GetCounter()
    {
        return counter;
    }


}