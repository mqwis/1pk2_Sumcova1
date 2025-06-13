namespace _1pk2_Sumcova1.Lesson_03.Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0; // вводим переменную х1
            double x2 = 0; // вводим переменную х2
            double h = 0.5; // вводим переменную высоты
            Console.WriteLine("Введите числа с диапозоном от -4 до 4"); // команда для вывода текста в консоль
            while (true)
            {
                x1 = Convert.ToDouble(Console.ReadLine());  // конвертируем переменную в double 
                x2 = Convert.ToDouble(Console.ReadLine()); // конвертируем переменную в double

                if (x1 >= -4 && x2 <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Диапозон чисел неверный");
                }
            }
            double temp = (x2 - x1) / h; // вводим переменную temp 
            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine(x1 + " | " + Math.Abs(x1));
                x1 = x1 + h;
            }
            Console.WriteLine(x2 + " | " + Math.Abs(x2));
        }
    }
}
