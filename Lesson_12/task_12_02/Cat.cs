using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_02
{
    class Cat
    {
        public string name; // поле класса - хранит имя
        public string breed; // поле класса - хранит породу
        public double weight; // поле класса - хранит вес
        public int height; // поле класса - хранит рост

        public void CatInfo()
        {
            Console.WriteLine($"Кот '{name}', породы {breed}\nВесом - {weight} кг\nРостом - {height} см");
        }
            



    }
}
