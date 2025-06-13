
string filePath = @"C:\example\test.txt"; // Укажите путь к вашему файлу
string searchWord = "пример"; // Слово для поиска

List<string> foundLines = FindLinesWithWord(filePath, searchWord);

List<string> FindLinesWithWord(string filePath, string searchWord)
{
    throw new NotImplementedException();
}

if (foundLines.Count > 0)
{
    Console.WriteLine($"Найдены строки, содержащие слово '{searchWord}':");
    foreach (string line in foundLines)
    {
        Console.WriteLine(line);
    }
}
else
{
    Console.WriteLine($"Слово '{searchWord}' не найдено в файле.");
}
