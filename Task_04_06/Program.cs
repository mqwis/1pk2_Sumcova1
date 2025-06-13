namespace Task_04_06
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] numbers = new int[10]; // массив на 10 чисел
            int max = 0; // для хранения максимума по модулю

            // заполняем массив
            for (int i = 0; i < numbers.Length; i++)
            {
                int num;
                bool exists;

                // генерируем число и проверяем его уникальность
                while (true)
                {
                    num = rand.Next(-100, 101); // случайное число от -100 до 100
                    exists = false;

                    // проверяем, есть ли такое число по модулю
                    for (int j = 0; j < i; j++)
                    {
                        if (Math.Abs(numbers[j]) == Math.Abs(num))
                        {
                            exists = true;
                            break;
                        }
                    }

                    // если число уникальное, выходим из цикла
                    if (!exists)
                    {
                        break;
                    }
                }

                numbers[i] = num; // добавляем уникальное число в массив
            }

            // ищем максимум по модулю
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(max))
                {
                    max = numbers[i];
                }
            }

            // выводим массив и результат
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Наибольшее число по модулю : " + max);
        }
    }
}

