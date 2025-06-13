namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение температуры:"); // вводим команду для вывода текста в консоль
            double c1 = Convert.ToDouble(Console.ReadLine()); // вводим переменную  начальной температуры по цельсию
            Console.WriteLine("Введите конечное значение температуры:"); // вводим команду для вывода текста в консоль
            double c2 = Convert.ToDouble(Console.ReadLine());  //вводим переменную конечной температуры по цельсию 
            Console.WriteLine("Введите шаг:"); // вводим команду длля вывода текста в консоль
            double step = Convert.ToDouble(Console.ReadLine());  // вводим переменную шага
            double count = Math.Round(c2 / step); // вводим переменную счета

            double currentTempC = c1; // вводим переменную текущей температуры цельсия
            double currentTempF = currentTempC * 1.8 + 32; // вводим переменную текущей температуры по фарингейту
            Console.Write(currentTempC); // вывод счета температуры по цельсию в консоль
            Console.Write(" | ");
            Console.Write(currentTempF); // вывод счета температуры по фарингейту в консоль
            Console.WriteLine();

            for (int i = 0; i < count; i++) // вводим цикл 
            {
                currentTempC = currentTempC + step; // формула счета температуры по цельсию 
                currentTempF = (currentTempC * 1.8 + 32); // формула счета температуры по фарингейте
                Console.Write(currentTempC); // вывод счета температуры по цельсию в консоль
                Console.Write(" | ");
                Console.Write(currentTempF); // вывод счета температуры по фарингейту в консоль
                Console.WriteLine();
            }
        }
    }
}
