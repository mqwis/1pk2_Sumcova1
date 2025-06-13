using static task_20_04.VehicleTracker;
using task_20_04;

VehicleTracker tracker = new VehicleTracker();

// Добавляем несколько транспортных средств
tracker.AddVehicle(VehicleType.Car);
tracker.AddVehicle(VehicleType.Truck);
tracker.AddVehicle(VehicleType.Car);
tracker.AddVehicle(VehicleType.Bike);
tracker.AddVehicle(VehicleType.Truck);
tracker.AddVehicle(VehicleType.Bus);
tracker.AddVehicle(VehicleType.Motorcycle);

// Выводим информацию о всех транспортных средствах
tracker.DisplayAllVehicles();
Console.WriteLine();

// Подсчитываем количество грузовиков
int truckCount = tracker.CountVehiclesByType(VehicleType.Truck);
Console.WriteLine($"Количество грузовиков: {truckCount}");
Console.WriteLine();

// Находим и выводим информацию о всех машинах
tracker.DisplayVehiclesByType(VehicleType.Car);
Console.WriteLine();

// Находим и выводим информацию о всех мотоциклах
tracker.DisplayVehiclesByType(VehicleType.Motorcycle);
Console.WriteLine();

// Пробуем найти несуществующий тип
tracker.DisplayVehiclesByType(VehicleType.Bike);

Console.ReadKey();
        
