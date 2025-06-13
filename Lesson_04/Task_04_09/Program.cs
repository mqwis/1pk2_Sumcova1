namespace _1pk2_Sumcova1.Lesson_04.Task_04_09
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[10]; // массив на 10 чисел

            // вводим текст в консоль

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 21);
            }

            Console.Write("Уникальные элементы в массиве: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}