using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_01
{
    class Newspaper
    {
        public double date; // поле класса - хранение даты
        public string name; // поле класса - хранение названия
        public string heading; // поле класса - хранение заголовка
        public int quantity; // поле класса - храние кол-во страниц
        public double price; // поле класса - хранит цену

        // Метод для покупки газеты
        public void Buy()
        {
            Console.WriteLine($"Газета '{name}' куплен за {price} руб.");
        }

        // Метод для просмотра содержания журнала
        public void ViewContent()
        {
            Console.WriteLine($"Заголовок '{heading}':");
        }
    }
}
