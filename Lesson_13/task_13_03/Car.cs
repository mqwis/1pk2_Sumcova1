using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_03
{
    class Car
    {
        // Свойства
        public string LicensePlate { get; set; } // Номер авто
        public string Brand { get; set; } // Марка
        public string Color { get; set; } // Цвет
        public int CurrentSpeed { get; private set; } // Текущая скорость (только для чтения извне)
        public int MaxAllowedSpeed { get; set; } // Максимально допустимая скорость

        // Конструкторы
        // Конструктор по умолчанию
        public Car()
        {
            LicensePlate = "Неизвестно";
            Brand = "Неизвестно";
            Color = "Неизвестно";
            CurrentSpeed = 0;
            MaxAllowedSpeed = 120; // По умолчанию допустимая скорость 120 км/ч
        }

        // Конструктор с параметрами для инициализации всех свойств
        public Car(string licensePlate, string brand, string color, int maxAllowedSpeed)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0;
            MaxAllowedSpeed = maxAllowedSpeed;
        }

        // Конструктор для инициализации только номера и марки
        public Car(string licensePlate, string brand)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = "Неизвестно";
            CurrentSpeed = 0;
            MaxAllowedSpeed = 120; // По умолчанию допустимая скорость 120 км/ч
        }

        // Методы
        // Езда (равномерное ускорение скорости)
        public void Drive(int acceleration)
        {
            if (acceleration <= 0)
            {
                Console.WriteLine("Ускорение должно быть положительным числом.");
                return;
            }

            CurrentSpeed += acceleration;
            Console.WriteLine($"Скорость увеличена до {CurrentSpeed} км/ч.");

            // Проверка на превышение допустимой скорости
            if (CurrentSpeed > MaxAllowedSpeed)
            {
                Brake();
            }
        }

        // Торможение (остановка при превышении допустимой скорости)
        public void Brake()
        {
            if (CurrentSpeed > MaxAllowedSpeed)
            {
                Console.WriteLine($"Превышена допустимая скорость {MaxAllowedSpeed} км/ч. Автомобиль останавливается.");
                CurrentSpeed = 0;
            }
            else
            {
                Console.WriteLine("Торможение не требуется. Скорость в пределах допустимой.");
            }
        }

        // Вывод информации об автомобиле
        public void PrintInfo()
        {
            Console.WriteLine($"Номер авто: {LicensePlate}");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
            Console.WriteLine($"Максимально допустимая скорость: {MaxAllowedSpeed} км/ч");
        }
    }
}
