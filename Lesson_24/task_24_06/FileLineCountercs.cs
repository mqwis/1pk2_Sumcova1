using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24_06
{
    internal class FileLineCountercs
    {
        public static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            try
            {
                // Используем StreamReader в блоке using для автоматического освобождения ресурсов
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Читаем файл построчно до конца
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл не найден: {filePath}");
                return -1; // Возвращаем -1 как индикатор ошибки
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Директория не найдена: {Path.GetDirectoryName(filePath)}");
                return -1;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Нет доступа к файлу: {filePath}");
                return -1;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                return -1;
            }

            return lineCount;
        }
    }
}
