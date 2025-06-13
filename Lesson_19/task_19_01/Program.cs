Console.WriteLine("Введите произвольный текст:");
string text = Console.ReadLine();

Console.WriteLine("Введите подстроку для поиска:");
string searchSubstring = Console.ReadLine();

if (text.Contains(searchSubstring))
{
    Console.WriteLine("Подстрока найдена. Введите текст для замены:");
    string replacement = Console.ReadLine();

    string newText = text.Replace(searchSubstring, replacement);
    Console.WriteLine("Результат после замены:");
    Console.WriteLine(newText);
}
else
{
    Console.WriteLine("Подстрока не найдена в тексте.");
}
