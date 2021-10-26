using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

namespace Task1
{
    // 1. Создать консольное приложение, которое при старте выводит приветствие,
    // записанное в настройках приложения(application-scope).
    // Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
    // При следующем запуске отобразить эти сведения.
    // Задать приложению версию и описание.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = "App.config" };
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

                // Загрузить профиль пользователя
                string name = config.AppSettings.Settings["name"].Value;
                string age = config.AppSettings.Settings["age"].Value;
                string profession = config.AppSettings.Settings["profession"].Value;
                Console.WriteLine($"Привет, {profession} {name} {age} лет");

                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                age = Console.ReadLine();
                Console.Write("Введите род деятельности: ");
                profession = Console.ReadLine();

                Console.WriteLine();

                //Сохранить профиль пользователя
                config.AppSettings.Settings["name"].Value = name;
                config.AppSettings.Settings["age"].Value = age;
                config.AppSettings.Settings["profession"].Value = profession;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}