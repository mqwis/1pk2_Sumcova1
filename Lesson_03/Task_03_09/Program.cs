namespace _1pk2_Sumcova1.Lesson_03.Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начальная сумма вклада"); // вводим текст в консоль
            double x = Convert.ToInt32(Console.ReadLine()); // вводим переменную и конвертируем ее
            Console.WriteLine("Проценты"); // вводим текст мв консоль
            double p = Convert.ToInt32(Console.ReadLine()); // вводим переменную процентов и конвентируем ее
            Console.WriteLine("Желаемая сумма вклада"); // вводим текст в консоль
            double y = Convert.ToInt32(Console.ReadLine()); // вводим третью переменную 

            int count = 0;
            while (x < y) // вводим цикл 
            {
                x = Math.Floor(x * (1 + p / 100)); // вводим формулу для х
                count++;
            }

            Console.WriteLine(count);
        }
    }
}

