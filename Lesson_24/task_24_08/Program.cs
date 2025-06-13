
Console.WriteLine("=== Программа замены текста в файле ===");

Console.Write("Введите путь к файлу: ");
string filePath = Console.ReadLine();

if (File.Exists(filePath))
{
    SearchAndReplaceInFile(filePath);
}
else
{
    Console.WriteLine("Указанный файл не существует!");
}

void SearchAndReplaceInFile(string filePath)
{
    throw new NotImplementedException();
}

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
    
