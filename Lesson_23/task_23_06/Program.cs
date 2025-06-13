using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 1. Вывод информации о всех дисках в системе
        Console.WriteLine("1. Информация о дисках:");
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        foreach (DriveInfo d in allDrives)
        {
            Console.WriteLine($"  Диск {d.Name}");
            Console.WriteLine($"    Тип: {d.DriveType}");
            if (d.IsReady)
            {
                Console.WriteLine($"    Файловая система: {d.DriveFormat}");
                Console.WriteLine($"    Доступно места: {d.AvailableFreeSpace / (1024 * 1024 * 1024)} GB из {d.TotalSize / (1024 * 1024 * 1024)} GB");
            }
            Console.WriteLine();
        }

        // 2. Вывод содержимого каталога C:\Users (названия папок)
        Console.WriteLine("\n2. Содержимое каталога C:\\Users:");
        string usersPath = @"C:\Users";
        try
        {
            string[] userDirs = Directory.GetDirectories(usersPath);
            foreach (string dir in userDirs)
            {
                Console.WriteLine($"  {Path.GetFileName(dir)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  Ошибка при чтении каталога: {ex.Message}");
        }

        // 3. Создание папки "work" на диске D и работа в ней
        Console.WriteLine("\n3. Работа с каталогом D:\\work:");
        string workPath = @"D:\work";
        try
        {
            // Создание основной папки
            if (!Directory.Exists(workPath))
            {
                Directory.CreateDirectory(workPath);
                Console.WriteLine("  Каталог D:\\work создан.");
            }
            else
            {
                Console.WriteLine("  Каталог D:\\work уже существует.");
            }

            // 3a. Создание вложенного каталога "temp"
            string tempPath = Path.Combine(workPath, "temp");
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
                Console.WriteLine("  Вложенный каталог temp создан.");
            }
            else
            {
                Console.WriteLine("  Вложенный каталог temp уже существует.");
            }

            // 3b. Вывод информации о текущем каталоге
            Console.WriteLine("\n  Информация о текущем каталоге:");
            DirectoryInfo workDir = new DirectoryInfo(workPath);
            Console.WriteLine($"    Имя: {workDir.Name}");
            Console.WriteLine($"    Полный путь: {workDir.FullName}");
            Console.WriteLine($"    Родительский каталог: {workDir.Parent}");
            Console.WriteLine($"    Дата создания: {workDir.CreationTime}");
            Console.WriteLine($"    Атрибуты: {workDir.Attributes}");

            // 3c. Вывод информации о вложенном каталоге
            Console.WriteLine("\n  Информация о вложенном каталоге temp:");
            DirectoryInfo tempDir = new DirectoryInfo(tempPath);
            Console.WriteLine($"    Имя: {tempDir.Name}");
            Console.WriteLine($"    Полный путь: {tempDir.FullName}");
            Console.WriteLine($"    Родительский каталог: {tempDir.Parent}");
            Console.WriteLine($"    Дата создания: {tempDir.CreationTime}");
            Console.WriteLine($"    Атрибуты: {tempDir.Attributes}");

            // 4. Перемещение каталога "temp" в "D:\work\newTemp"
            Console.WriteLine("\n4. Перемещение каталога temp:");
            string newTempPath = @"D:\work\newTemp";
            try
            {
                if (Directory.Exists(newTempPath))
                {
                    Directory.Delete(newTempPath, true);
                }
                Directory.Move(tempPath, newTempPath);
                Console.WriteLine("  Каталог успешно перемещен из D:\\work\\temp в D:\\work\\newTemp");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Ошибка при перемещении каталога: {ex.Message}");
            }

            // 5. Попытка удаления каталога "D:\work\temp" (который уже перемещен)
            Console.WriteLine("\n5. Попытка удаления каталога D:\\work\\temp:");
            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath);
                    Console.WriteLine("  Каталог D:\\work\\temp успешно удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Ошибка при удалении каталога: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("  Каталог D:\\work\\temp не существует (уже перемещен или удален).");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  Ошибка при работе с каталогами: {ex.Message}");
        }

        Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
