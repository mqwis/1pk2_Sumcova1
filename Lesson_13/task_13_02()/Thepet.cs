using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_02__
{
    class Thepet
    {
        public string Name { get; set; } // Кличка
        public string Species { get; set; } // Вид животного
        public int Age { get; set; } // Возраст
        public double Weight { get; set; } // Вес
        public bool IsHealthy { get; set; } // Отметка о состоянии здоровья

        // Конструкторы
        // Конструктор по умолчанию
        public Thepet()
        {
            Name = "Неизвестно";
            Species = "Неизвестно";
            Age = 0;
            Weight = 0.0;
            IsHealthy = false;
        }

        // Конструктор с параметрами для инициализации всех свойств
        public Thepet(string name, string species, int age, double weight, bool isHealthy)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        // Конструктор для инициализации только клички и вида
        public Thepet(string name, string species)
        {
            Name = name;
            Species = species;
            Age = 0;
            Weight = 0.0;
            IsHealthy = false;
        }

        // Методы
        // Вывод информации о питомце
        public void PrintInfo()
        {
            Console.WriteLine($"Кличка: {Name}");
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
        }

        // Изменение веса животного
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Вес изменен на {Weight} кг");
        }

        // Изменение отметки о состоянии здоровья
        public void ChangeHealthStatus(bool newHealthStatus)
        {
            IsHealthy = newHealthStatus;
            Console.WriteLine($"Состояние здоровья изменено на {(IsHealthy ? "Здоров" : "Нездоров")}");
        }
    }

}
