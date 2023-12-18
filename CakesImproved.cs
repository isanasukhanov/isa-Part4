/*Дорабатываем задачу Cakes

Необходимо сделать так, чтобы названия и цены тортов брались из файла cakes.txt.
Файл должен быть в той же папке где выполняется программа (в пути просто не указывайте ничего кроме названия файла).

Формат хранения данных - коллекция строк, где каждая строка представлена в виде:

НАЗВАНИЕ_ТОРТА:ЦЕНА

Если файл не существует, его надо создать и предложить пользователю заполнить его путем ввода

НАЗВАНИЕ_ТОРТА ЦЕНА

Повторять ввода пока не встретится пустая строка*/

public static class CakesImproved
{
    const string PATH = @"CakesPrice.txt";

    static void Main(string[] args)
    {
        Start();
    }

    static void Start()
    {
        string[] modes ={ "1 - Выбор торта", "2 - Внести в прайс новый торт" };
        int? mode = InputService.SelectMode(modes);

        switch (mode)
        {
            case 1:
                FindCake();
                break;

            case 2:
                AddCake();
                break;
        }
    }

    static void FindCake()
    {
        Console.Clear();

        //Создаем переменную для списка всех тортов
        var allCakes = GetCakesFromFile();

        Console.WriteLine("Введите название торта: ");
        string? selectedName = Console.ReadLine();

        var foudCake = allCakes.Find(cake => cake.Title.ToLower() == selectedName.ToLower());
        if (foudCake == null)
        {
            Console.WriteLine("Нет такого торта");
            Console.ReadKey();
            FindCake();
        }
        else
        {
            Console.WriteLine($"{foundCake.Title}:{foundCake.Prise}, ингридиенты = {foundCake}");
        }
    }

    private static void AddCake()
    {
        Console.Clear();
        Console.WriteLine("Введите данные о торте");

        Console.Write("Название: ");
        string? title = Console.ReadLine();

        Console.WriteLine("Ингридиенты: ");
        string? ingredients = Console.ReadLine();
        
         


    }