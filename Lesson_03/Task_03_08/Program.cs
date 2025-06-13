namespace _1pk2_Sumcova1.Lesson_03.Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное натуральное число"); // вводим в консоль надпись
            int num1 = Convert.ToInt32(Console.ReadLine()); // вводим первую переменную и конвертируем ее
            Console.WriteLine("Введите конечное натуральное число"); // вводим в консоль надпись
            int num2 = Convert.ToInt32(Console.ReadLine()); // вводим вторую переменую и конвеентируем ее

            int temp = num2 - num1; // вводим третью переменнную и формулу для нее
            for (int i = 0; i < temp; i++) // вводим цикл 
            {
                if (num1 % 3 == 0 && num1 % 5 != 0) // вводим цикл с условием
                {
                    Console.WriteLine(num1); // выводим в консоль первую переменную
                }

                num1 = num1 + 1;
            }
        }
    }
}
