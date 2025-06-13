using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24_08
{
    internal class FileTextReplacer
    {
        public static void SearchAndReplaceInFile(string filePath)
        {
            try
            {
                // Запрашиваем у пользователя данные для поиска и замены
                Console.Write("Введите текст для поиска: ");
                string searchText = Console.ReadLine();

                Console.Write("Введите текст для замены: ");
                string replaceText = Console.ReadLine();

                // Читаем весь файл
                string fileContent = File.ReadAllText(filePath, Encoding.UTF8);

                // Заменяем текст (регистронезависимо)
                fileContent = ReplaceTextCaseInsensitive(fileContent, searchText, replaceText);

                // Записываем изменения обратно в файл
                File.WriteAllText(filePath, fileContent, Encoding.UTF8);

                Console.WriteLine("Замена выполнена успешно!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Ошибка: Файл не найден: {filePath}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Ошибка: Директория не найдена: {Path.GetDirectoryName(filePath)}");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Ошибка: Нет доступа к файлу: {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }

        private static string ReplaceTextCaseInsensitive(string input, string searchText, string replaceText)
        {
            // Используем StringBuilder для эффективной работы со строками
            StringBuilder result = new StringBuilder();
            int position = 0;
            int index;

            while ((index = input.IndexOf(searchText, position, StringComparison.OrdinalIgnoreCase)) >= 0)
            {
                // Добавляем текст до найденного вхождения
                result.Append(input.Substring(position, index - position));

                // Добавляем текст замены
                result.Append(replaceText);

                // Перемещаем позицию после найденного текста
                position = index + searchText.Length;
            }

            // Добавляем оставшийся текст
            result.Append(input.Substring(position));

            return result.ToString();
        }
    }
}
