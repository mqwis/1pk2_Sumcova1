using task_21_02;

string text = "Основы алгоритмизации и программирования топ";
var result = WordCounter.CountWordOccurrences(text);

foreach (var pair in result)
{
    Console.WriteLine($"Слово: '{pair.Key}', Количество: {pair.Value}");
}
