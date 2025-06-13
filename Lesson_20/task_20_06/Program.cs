using static task_20_06.TrafficLightSimulator;

TrafficLightColor currentColor = TrafficLightColor.Red;
bool manualMode = false;
ConsoleKeyInfo keyInfo;

Console.WriteLine("Симулятор светофора\n");
Console.WriteLine("Нажмите 'M' для переключения в ручной режим.");
Console.WriteLine("В ручном режиме используйте 'R', 'Y', 'G' для переключения цветов.");
Console.WriteLine("Нажмите 'Esc' для выхода.");

while (true)
{
    if (Console.KeyAvailable)
    {
        keyInfo = Console.ReadKey(true); // Считываем нажатие клавиши, не отображая ее в консоли

        if (keyInfo.Key == ConsoleKey.Escape)
        {
            break; // Выход из программы
        }
        else if (keyInfo.Key == ConsoleKey.M)
        {
            manualMode = !manualMode; // Переключение режима
            Console.WriteLine($"\nРучной режим: {(manualMode ? "Включен" : "Выключен")}\n");
            if (!manualMode)
            {
                //После выхода из ручного режима, возвращаем автоматический цикл переключения
                currentColor = TrafficLightColor.Red; //Сбрасываем цвет на красный, чтобы цикл был предсказуемым
                DisplayColor(currentColor);
            }

        }
        else if (manualMode)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.R:
                    currentColor = TrafficLightColor.Red;
                    break;
                case ConsoleKey.Y:
                    currentColor = TrafficLightColor.Yellow;
                    break;
                case ConsoleKey.G:
                    currentColor = TrafficLightColor.Green;
                    break;
                default:
                    Console.WriteLine("Некорректная клавиша в ручном режиме. Используйте 'R', 'Y', 'G'.");
                    continue; // Пропускаем остальную часть цикла и ждем следующего нажатия
            }
            DisplayColor(currentColor);
        }
        else
        {
            Console.WriteLine("Нажмите 'M' для переключения в ручной режим или 'Esc' для выхода.");
            continue;
        }
    }
    // Автоматический режим
    if (!manualMode)
    {
        DisplayColor(currentColor);
        Thread.Sleep(3000); // Задержка 3 секунды

        switch (currentColor)
        {
            case TrafficLightColor.Red:
                currentColor = TrafficLightColor.Green;
                break;
            case TrafficLightColor.Green:
                currentColor = TrafficLightColor.Yellow;
                break;
            case TrafficLightColor.Yellow:
                currentColor = TrafficLightColor.Red;
                break;
        }
    }
}
static void DisplayColor(TrafficLightColor color)
{
    Console.Clear(); // Очищаем консоль для наглядности
    Console.WriteLine($"Текущий цвет: {color}");
    if (color == TrafficLightColor.Red) Console.WriteLine("Стоп!");
    else if (color == TrafficLightColor.Yellow) Console.WriteLine("Внимание!");
    else if (color == TrafficLightColor.Green) Console.WriteLine("Можно ехать!");
}