using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task__2_02
{
    class Thepet
    {
        public string name; // поле класса - хранит имя
        public string view; // поле класса - хранит вид
        public double weight; // поле класса - хранит вес
        public string health; // поле класса - хранит отметку о здоровье
        private string v1;
        private string v2;

        public void Info()
        {
            Console.WriteLine($"Имя - {name}\nВид - {view}\nВес - {health}");
        }
        public void MWeighr()
        {
            Console.WriteLine("Изменение веса");
            double weight = Convert.ToDouble(Console.ReadLine());
        }

        public void Mheaith()
        {
            Console.WriteLine("Изменениe отметки о состоянии здоровья");
            string health = Convert.ToString(Console.ReadLine());
        }

        #region
        public Thepet(string name, string view, double weight, string heaith)
        {
            this.name = name;
            this.view = view;
            this.weight = weight;
            this.health = heaith;
        }

        #endregion
        #region
        public Thepet(string name, string view, double weight)
        {
            this.name = name;
            this.view = view;
            this.weight = weight;
        }
        #endregion
        #region
        public Thepet(string name, string view, string heaith)
        {
            this.name = name;
            this.view = view;
            this.health = heaith;
        }
        #endregion
        #region
        public Thepet(string name, double weight, string heaith)
        {
            this.name = name; 
            this.weight = weight;
            this.health = heaith;
        }

        public Thepet(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        #endregion
    }
}
