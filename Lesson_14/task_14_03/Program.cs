using task_14_03;

try
{
    // Пример вычисления факториала
    Console.WriteLine("Факториал 5: " + MathUtils.Factorial(5)); // 120
    Console.WriteLine("Факториал 0: " + MathUtils.Factorial(0)); // 1

    // Попытка вычислить факториал отрицательного числа
    Console.WriteLine("Факториал -3: " + MathUtils.Factorial(-3)); // Выбросит исключение
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // Обработка исключения
}
