

string filePath = @"C:\example\test.txt";
int count = CountLinesInFile(filePath);

int CountLinesInFile(string filePath)
{
    throw new NotImplementedException();
}

if (count >= 0)
{
    Console.WriteLine($"Файл содержит {count} строк.");
}