List<string> lines = new List<string>();

Console.WriteLine("Вводите строки. Для завершения ввода введите пустую строку (нажмите Enter без текста):");

while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        break; // Ввод завершён

    lines.Add(input);
}

if (lines.Count > 0)
{
    string combinedString = string.Join("-", lines);
    Console.WriteLine("\nРезультат объединения строк:");
    Console.WriteLine(combinedString);
}
else
{
    Console.WriteLine("Не было введено ни одной строки.");
}
