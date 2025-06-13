Console.WriteLine("Введите текст (содержащий предложения с знаками препинания):");
string text = Console.ReadLine();

// a) Разделение по пробелам (отдельные слова)
Console.WriteLine("\n--- Слова, разделенные пробелами ---");
string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string word in words)
{
    Console.WriteLine(word);
}

// b) Разделение по предложениям (по знакам .!?)
Console.WriteLine("\n--- Предложения, разделенные знаками препинания ---");
string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string sentence in sentences)
{
    string trimmedSentence = sentence.Trim(); // Удаляем лишние пробелы
    if (!string.IsNullOrEmpty(trimmedSentence))
    {
        Console.WriteLine(trimmedSentence);
    }
}
