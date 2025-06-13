namespace _1pk2_Sumcova1.Lesson_03.Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение интервала времени"); // команда для вывода текста в консоль
            double t1 = Convert.ToDouble(Console.ReadLine()); // вводим переменную и конвентируем ее 
            Console.WriteLine("Введите конечное значение интервала времени"); // команда для вывода текста в консоль
            double t2 = Convert.ToDouble(Console.ReadLine()); // вводим переменную и конвентируем ее 

            double step = 0.5; // вводим переменную шага

            double temp = (t2 - t1) / step; // вводим переменную

            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine(t1 + " | " + t1 * 9.8);
                t1 = t1 + step;
            }
        }
    }
}
