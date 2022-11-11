// class Run
// {
//     static void Main(string[] arg)
//     {
//         Console.Clear();
        
//         DbRepository dbRepository = new DbRepository();
//         dbRepository.GetData();
//     }
// }
// Класс который должен организовывать работу с какой-нибудь SQL базой данных

class DbRepository
{
    private static string connectoinString;

    static DbRepository()                   // Будет использоваться 1 раз и не нельзя будет вызвать еще раз, что не создаст большую перегрузку данных
    {
        ConfigurationManager configuration = new ConfigurationManager();
        connectoinString = configuration.GetConnectionString();
    }

    public void GetData()
    {
        Console.WriteLine($"Использую: {connectoinString}");
    }
}

class ConfigurationManager                          // Для извлечения данных из config-файла
{
    public string GetConnectionString()
    {
            return "local DB!";     // Заглушка. Вреальном проекте: обращение к config-файлу
    }
    
}
