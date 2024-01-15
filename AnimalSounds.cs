 /* Задание:
Создайте консольное приложение на C#, которое спрашивает пользователя, 
какое животное он хочет услышать, 
и в ответ выводит характерный звук этого животного.

Шаги реализации:
Начало программы:
Программа должна приветствовать пользователя и спрашивать, какое животное он хочет услышать.

Выбор животного:
Пользователь вводит название животного (например, "кошка", "собака", "корова").

Вывод звука:
В зависимости от выбора животного, программа должна выводить соответствующий звук 
(например, "мяу" для кошки, "гав" для собаки, "муу" для коровы).
Если пользователь вводит название животного, которого нет в программе, 
выводится сообщение: "Я не знаю, какой звук издает это животное". */


public static class AnimalSounds
{
    public static void Start()
    {
        string animal1 = "Кошка";
        string animal2 = "Собака";
        string animal3 = "Корова";

        string animal4 = "Мяу";
        string animal5 = "Гав";
        string animal6 = "Муу";
        string animal7 = "Я не знаю, какой звук издает это животное";
        string otvetpolzovatelya;
        Console.WriteLine("Привет пользователь! Какое животное вы хотите услышать?");
        otvetpolzovatelya = Console.ReadLine();

        if(otvetpolzovatelya == animal1)
        {
            Console.WriteLine($"Для{animal1}звук {animal4}");
        }
        else if(otvetpolzovatelya == animal2)
        {
            Console.WriteLine($"Для{animal2}звук{animal5}");
        }
        else if(otvetpolzovatelya == animal3)
        {
            Console.WriteLine($"Для{animal3}звук{animal6}");
        }
        else
        {
            Console.WriteLine("Я не знаю, какой звук издает это животное");
        }

    }
}

       