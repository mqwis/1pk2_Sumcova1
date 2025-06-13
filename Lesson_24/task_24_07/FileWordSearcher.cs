using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24_07
{
    internal class FileWordSearcher
    {
        public static List<string> FindLinesWithWord(string filePath, string searchWord)
        {
            List<string> matchingLines = new List<string>();

            try
            {
                // Читаем все строки из файла
                var lines = File.ReadAllLines(filePath);

                // Ищем строки, содержащие искомое слово (регистронезависимо)
                matchingLines = lines
                    .Where(line => line.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл не найден: {filePath}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Директория не найдена: {Path.GetDirectoryName(filePath)}");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Нет доступа к файлу: {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }

            return matchingLines;
        }
    }
}
