public static class LogAnalyzer
{
    const string PROBEL = " ";
    static string GetTime(string log)
    {
        // извлечь время - строка от первого пробела до второго пробела
        int firstIndex = log.IndexOf(PROBEL) +1;
        int secondIndex = log.IndexOf(PROBEL, firstIndex );
        int length = secondIndex - (firstIndex );
        string time = log.Substring(firstIndex, length);

        return time;
    }
    static string GetDate(string log) 
    {
        /* firstindex = 10,secondindex 19,log.length = 57 
         "2023-11-12 08:30:00 INFO Application started successfully",
          Как извлечь дату из log - строка от начало до первого пробела.
            1. Найти индекс первого пробела (indexProbela)
            2. Создать переменную для хранения даты (date)
            3. Извлечь подстроку от индекса 0 до indexProbela и сохранить в date
            4. Вернуть date
            5.
        */

        int indexProbela = log.IndexOf(PROBEL);
        string date;
        date = log.Substring(0, indexProbela);

        return date;
    }

    public static void Start()
    {

        /* Задача: Программа Анализа Заранее Определённых Логов

        Описание:
        Создайте программу на C#, которая обрабатывает фиксированный набор из 10 строк 
        логов. 
        Каждая строка лога содержит дату, время, уровень важности
         события (ERROR, WARNING, INFO) и сообщение. 
        Программа должна извлекать определенные части из этих строк и форматировать их
         для более удобного отображения.

        Требования:
        Фиксированный набор строк логов: В программе должен быть определен массив или 
        список из 10 строк логов. 
        Например, string[] logs = new string[] { "2023-11-12 10:00:00 ERROR Some error
        occurred", ... };

        Методы для обработки строк: Создайте методы, использующие Substring, 
        IndexOf и другие методы работы со строками для извлечения даты, времени, 
        уровня важности и сообщения из каждой строки лога.

        Форматированный вывод: Программа должна обрабатывать каждую строку из 
        вашего набора логов
         и выводить информацию в удобном для чтения формате, например: 
         "Дата: 2023-11-12, Время: 10:00:00, Уровень: ERROR, Сообщение: Some 
         error occurred".

        Цикл для обработки строк логов: Используйте цикл для перебора всех строк 
        в вашем наборе и применения к ним методов обработки.

        Пример работы программы:
        Программа последовательно выводит обработанную информацию для каждой 
        из 10 строк логов.

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

        foreach ( string log in logs)
        {
            string date = GetDate(log);
            Console.WriteLine($"Дата: {date}");

            string time = GetTime(log);
            Console.WriteLine($"время: {time}");
        }
        





    }
}
