namespace _1pk2_Sumcova1.Lesson_04.Task_04_10
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] array = new int[10]; // массив на 10 чисел

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11); // цикл
            }

            Console.WriteLine("Исходный массив:"); // вводим текст в консоль
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); // цикл 
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length / 4; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length / 2 - 1 - i]; // цикл 
                array[array.Length / 2 - 1 - i] = temp;
            }

            for (int i = array.Length / 2; i < array.Length / 2 + array.Length / 4; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - (i - array.Length / 2)]; // цикл
                array[array.Length - 1 - (i - array.Length / 2)] = temp;
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

