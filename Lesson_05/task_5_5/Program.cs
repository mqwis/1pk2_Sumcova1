namespace _1pk2_Sumcova1.Lesson_05.task_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-99, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        arr[i, j] = arr[i, j] * -1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arr[i, j] + " " + '\t');
                        Console.ResetColor();
                    }
                    else if (arr[i, j] == 0)
                    {
                        arr[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(arr[i, j] + " " + '\t');
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arr[i, j] + " " + '\t');
                    }
                }
                Console.WriteLine();
            }


        }
    }
}