namespace _1pk2_Sumcova1.Lesson_05.task_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[10, 5];

            for (int i = 0; i < 10; i++)
            {
                arr[i, 0] = 0;
                arr[i, 1] = (i + 1) * 2;
                arr[i, 2] = (i + 2) * 3;
                arr[i, 3] = (i + 3) * 4;
                arr[i, 4] = (i + 4) * 5;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int[,] arr2 = new int[5, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[j, i] = arr[i, j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}