using task_13_02__;

static void Main(string[] args)
{
    // Создание объекта с использованием конструктора по умолчанию
    Thepet pet1 = new Thepet();
    pet1.PrintInfo();

    // Создание объекта с использованием конструктора с параметрами
    Thepet pet2 = new Thepet("Барсик", "Кот", 3, 4.5, true);
    pet2.PrintInfo();

    // Изменение веса и состояния здоровья
    pet2.ChangeWeight(5.0);
    pet2.ChangeHealthStatus(false);
    pet2.PrintInfo();

    // Создание объекта с использованием конструктора для инициализации только клички и вида
    Thepet pet3 = new Thepet("Шарик", "Собака");
    pet3.PrintInfo();
}
