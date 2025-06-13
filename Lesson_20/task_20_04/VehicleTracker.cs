using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_04
{
    internal class VehicleTracker
    {
        public enum VehicleType
        {
            Car,
            Bike,
            Bus,
            Truck,
            Motorcycle
        }

        private List<VehicleType> vehicles;

        public VehicleTracker()
        {
            vehicles = new List<VehicleType>();
        }

        // Добавить транспортное средство
        public void AddVehicle(VehicleType type)
        {
            vehicles.Add(type);
        }

        // Удалить транспортное средство
        public void RemoveVehicle(VehicleType type)
        {
            vehicles.Remove(type);
        }

        // Подсчитать количество транспортных средств определенного типа
        public int CountVehiclesByType(VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        // Найти транспортные средства определенного типа
        public List<VehicleType> FindVehiclesByType(VehicleType type)
        {
            return vehicles.Where(v => v == type).ToList();
        }

        // Вывести информацию о всех транспортных средствах
        public void DisplayAllVehicles()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("Нет зарегистрированных транспортных средств.");
                return;
            }

            Console.WriteLine("Список всех транспортных средств:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"- {vehicle}");
            }
        }

        // Вывести информацию о транспортных средствах определенного типа
        public void DisplayVehiclesByType(VehicleType type)
        {
            List<VehicleType> foundVehicles = FindVehiclesByType(type);

            if (foundVehicles.Count == 0)
            {
                Console.WriteLine($"Нет транспортных средств типа {type}.");
                return;
            }

            Console.WriteLine($"Транспортные средства типа {type}:");
            foreach (var vehicle in foundVehicles)
            {
                Console.WriteLine($"- {vehicle}"); //  Можно сделать вывод более подробным, если нужно
            }
        }
    }
}





