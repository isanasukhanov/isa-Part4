/*  Задача: "Журнал погоды"
Цель
Разработать приложение для записи и чтения данных о погоде из файлов.

Функциональность
1. Выбор режима работы
При запуске, приложение предлагает выбор режима:
1 для чтения данных.
2 для записи данных.
2. Режим записи
Пользователь вводит информацию о погоде:
Дата: в формате дд.мм.гггг (например, 10.11.2012)
Температура: число с десятичной точкой.
Влажность: целое число.
Описание погоды: Например, Солнечно, Облачно, Дождь, Снег, Туман.
После добавления, программа сообщает об успешной записи.
Нажатие Enter возвращает пользователя к выбору режима.
3. Режим чтения
Пользователь вводит дату для отображения данных о погоде.
Приложение выводит данные в формате:
Дата: [дата], Погода: [описание], Температура: [температура]°C, Влажность: [влажность]%.
Если данных по введенной дате нет, выводится сообщение "Нет данных".
Нажатие Enter возвращает пользователя к выбору режима.
Дополнительные требования
Если файл для записи данных не существует, приложение должно его автоматически создать.
Обработка исключений: Приложение должно корректно обрабатывать ошибки при работе с файлами (например, защита от записи, недоступность файла) используя блоки try-catch.
В случае ошибки, программа выводит сообщение об ошибке и предлагает повторить попытку или выйти из программы. */

public static class WeatherJournal
{
    private static int? SelectMode()
    {
        Console.Clear();
        Console.WriteLine("Выберите режим: ");
        Console.WriteLine("1 - Чтение");
        Console.WriteLine("2 - Запись");

        try
        {
            int? mode = Convert.ToInt32(Console.ReadLine());
            if (mode != 1 && mode != 2)
            {
                return SelectMode();
            }
            return mode;
        }
        catch (Exception ex)
        {
            return SelectMode();
        }
    }

    public static void Start()
    {
        const string? path = @"C:\Users\IslamOrg\Desktop\Новая папка (2)\Погода\Weather.txt";
        int? mode = SelectMode();

        switch (mode)
        {
            case 1:
                Console.WriteLine("Введите дату:");
                string? selectedDate = Console.ReadLine();

                string contents = File.ReadAllText(path);
                string[] entries = contents.Split("\r\n");

                for (int i = 0; i < entries.Length -1; i++)
                {
                    string entry = entries[i];

                    if (entry.Contains(selectedDate))
                    {
                        string[] data = entry.Split(" ");
                        Console.WriteLine($"Дата: {data[0]}, Погода: {data[3]}, Температура: {data[1]}, Влажность: {data[2]}");        
                    }
                    else
                    {
                        Console.WriteLine("Нет данных.");
                    }
                }  
                break;

            case 2:
                Console.WriteLine("Введите информацию о погоде: ");

                Console.Write("Дата: ");
                string? date = Console.ReadLine();

                Console.Write("Температура: ");
                string? temperature = Console.ReadLine();

                Console.Write("Влажность: ");
                string? humidity = Console.ReadLine();

                Console.Write("Описание: ");
                string? description = Console.ReadLine();
                
                
                try
                {
                    File.AppendAllText(path, $"{date}{temperature}{humidity}{description}\r\n");
                }
                catch  (UnauthorizedAccessException)
                {
                    Console.WriteLine("Нет доступа к указанному пути");
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Возникла непонятная ошибка");
                    return;
                }

                Console.WriteLine("Строка успешно добавлена в файл: ");
                Console.ReadKey();
                Start();
                break;
        }

        Console.WriteLine($"mode: {mode}");

    }   

}
