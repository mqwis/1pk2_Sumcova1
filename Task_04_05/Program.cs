namespace Task_04_05
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] days = new int[30]; // вводим массив
            int max = -1;
            int maxDay = 0;
            string dry = "";
            int d1 = 0, d2 = 0, d3 = 0;

            for (int i = 0; i < 30; i++)
            {
                days[i] = rand.Next(0, 301); // цикл

                if (i < 10)
                {
                    d1 = d1 + days[i]; // цикл
                }
                else if (i < 20)
                {
                    d2 = d2 + days[i];
                }
                else
                {
                    d3 = d3 + days[i];
                }

                if (days[i] > max)
                {
                    max = days[i];
                    maxDay = i + 1;
                }

                if (days[i] == 0)
                {
                    dry += (i + 1) + " ";
                }
            }
            // вводим подписи в консоль
            Console.WriteLine("Общее количество осадков за:");
            Console.WriteLine($"1 декаду: {d1}");
            Console.WriteLine($"2 декаду: {d2}");
            Console.WriteLine($"3 декаду: {d3}");
            Console.WriteLine($"Самые сильные осадки в {maxDay} день");
            Console.Write("Сухие дни: ");
            if (dry == "")
            {
                Console.Write("нет");
            }
            else
            {
                Console.Write(dry);
            }
        }
    }
}

