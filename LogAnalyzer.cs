public static class LogAnalyzer
{
    const string PROBEL = " ";
    static string GetDate(string log)
    {
        int firstIndex = log.IndexOf(PROBEL);
        int dateLenght = firstIndex;
        string date = log.Substring(0, dateLenght);
        return date;
    }

    static string GetTime(string log)
    {
        int firstIndex = log.IndexOf(PROBEL);
        int secondIndex =log.IndexOf(PROBEL, firstIndex +1);
        int timeLenght = secondIndex - firstIndex;
        string time = log.Substring(firstIndex +1,timeLenght);
        return time;
    }

    static string GetLevel(string log)
    {
        int firstIndex = log.IndexOf(PROBEL);
        int secondIndex = log.IndexOf(PROBEL,firstIndex+1);
        int thirdIndex =log.IndexOf(PROBEL,secondIndex+1);
        int levelLenght = thirdIndex - secondIndex;
        string level = log.Substring(secondIndex+1, levelLenght);
        return level;
    }

    static string GetMessage(string log)
    {
        int firstIndex = log.IndexOf(PROBEL);
        int secondIndex = log.IndexOf(PROBEL,firstIndex+1);
        int thirdIndex =log.IndexOf(PROBEL,secondIndex+1);
        string message = log.Substring(thirdIndex+1);
        return message;
    }    

    public static void Start()
    {
        /* Задача: Программа Анализа Заранее Определённых Логов.

        Описание:
        Создайте программу на C#, которая обрабатывает фиксированный набор из 10 строк логов. 
        Каждая строка лога содержит дату, время, уровень важности события (ERROR, WARNING, INFO) и сообщение. 
        Программа должна извлекать определенные части из этих строк и форматировать их для более удобного отображения.

        Требования:
        Фиксированный набор строк логов: В программе должен быть определен массив или список из 10 строк логов. 
        Например, string[] logs = new string[] { "2023-11-12 10:00:00 ERROR Some error occurred", ... };

        Методы для обработки строк: Создайте методы, использующие Substring, 
        IndexOf и другие методы работы со строками для извлечения даты, времени, уровня важности и сообщения из каждой строки лога.

        Форматированный вывод: Программа должна обрабатывать каждую строку из вашего набора логов
         и выводить информацию в удобном для чтения формате, например: 
         "Дата: 2023-11-12, Время: 10:00:00, Уровень: ERROR, Сообщение: Some error occurred".

        Цикл для обработки строк логов: Используйте цикл для перебора всех строк в вашем наборе и применения к ним методов обработки.

        Пример работы программы:
        Программа последовательно выводит обработанную информацию для каждой из 10 строк логов.

        Пример строк логов:
        2023-11-12 08:30:00 INFO Application started successfully
        2023-11-12 08:45:23 WARNING Low memory warning detected
        2023-11-12 09:15:45 ERROR Failed to connect to database
        2023-11-12 09:45:10 INFO User 'admin' logged in
        2023-11-12 10:00:00 ERROR Unexpected exception occurred
        2023-11-12 10:30:33 WARNING Disk space is almost full
        2023-11-12 11:00:05 INFO New user 'john_doe' created
        2023-11-12 11:30:00 INFO Scheduled maintenance started
        2023-11-12 12:00:00 ERROR Email service is not responding
        2023-11-12 12:30:45 WARNING High CPU usage detected */

        string[] logs = new string[] {
                        "2023-11-12 08:30:00 INFO Application started successfully",
                        "2023-11-12 08:45:23 WARNING Low memory warning detected",
                        "2023-11-12 09:15:45 ERROR Failed to connect to database",
                        "2023-11-12 09:45:10 INFO User 'admin' logged in",
                        "2023-11-12 10:00:00 ERROR Unexpected exception occurred",
                        "2023-11-12 10:30:33 WARNING Disk space is almost full",
                        "2023-11-12 11:00:05 INFO New user 'john_doe' created",
                        "2023-11-12 11:30:00 INFO Scheduled maintenance started",
                        "2023-11-12 12:00:00 ERROR Email service is not responding",
                        "2023-11-12 12:30:45 WARNING High CPU usage detected"
        };

        foreach (string log in logs)
        {
            string date = GetDate(log);
            string time = GetTime(log);
            string level = GetLevel(log);
            string message = GetMessage(log);
            Console.WriteLine($"Дата: {date} Время: {time} Уровень: {level.PadRight(8)} Сообщение: {message}");
           
        }

    }
}