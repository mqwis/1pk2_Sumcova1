namespace _1pk2_Sumcova1.Lesson_05.task_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                    arr2[i, j] = rnd.Next(1, 10);
                }
            }
            int[,] arr3 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int num = arr[i, j] * arr2[i, j];
                    arr3[i, j] = num;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr3[i, j] + " "+ '\t');
                }
                Console.WriteLine();
            }

        }
    }
}