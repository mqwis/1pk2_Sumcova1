List<int> originalNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> evenNumbersMultipliedBy10 = new List<int>();

foreach (int num in originalNumbers)
{
    if (num % 2 == 0)
    {
        evenNumbersMultipliedBy10.Add(num * 10);
    }
}

Console.WriteLine("Результат:");
foreach (int number in evenNumbersMultipliedBy10)
{
    Console.WriteLine(number);
}
