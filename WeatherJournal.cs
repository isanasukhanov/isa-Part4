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
    public static void Start()
    {
        

    }   

}
