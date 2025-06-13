using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_01
{
    class Journal
    {
        public double date; // поле класса - хранит дату
        public string direction; // поле класса - хранит предметно-тематическую направленииность 
        public string name; // поле класса - хранит название 
        public int quantity; // поле класса - храние кол-во страниц
        public double price; // поле класса - хранит цену
        public string content; // поле класса - содержание 

        // Метод для покупки журнала
        public void Buy()
        {
            Console.WriteLine($"Журнал '{name}' куплен за {price} руб.");
        }

        // Метод для просмотра содержания журнала
        public void ViewContent()
        {
            Console.WriteLine($"Содержание журнала '{name}':");
            foreach (var item in content)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
