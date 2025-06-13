using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_21_02
{
    internal class WordCounter
    {
        public static Dictionary<string, int> CountWordOccurrences(string text)
        {
            // Удаляем знаки пунктуации и приводим к нижнему регистру
            var cleanedText = Regex.Replace(text, @"[^\w\s]", "");

            // Разбиваем текст на слова, игнорируя пустые записи
            var words = cleanedText.Split(new[] { ' ', '\t', '\n', '\r' },
                                  StringSplitOptions.RemoveEmptyEntries);

            // Создаем и заполняем словарь
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}
