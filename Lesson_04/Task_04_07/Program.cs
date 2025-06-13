namespace _1pk2_Sumcova1.Lesson_04.Task_04_07
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] heights = new int[30]; // массив

            // вводим переменные 
            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            //вводим циклы

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = rand.Next(-180, 191);
            }

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] < 0)
                {
                    boysCount++;
                    boysSum += Math.Abs(heights[i]);
                }
                else
                {
                    girlsCount++;
                    girlsSum += heights[i];
                }
            }

            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            // вводим текст в консоль

            Console.WriteLine("Количество мальчиков: " + boysCount);
            Console.WriteLine("Количество девочек: " + girlsCount);
            Console.WriteLine("Средний рост мальчиков: " + boysAverage.ToString("0.00") + " см");
            Console.WriteLine("Средний рост девочек: " + girlsAverage.ToString("0.00") + " см");
        }
    }
}

