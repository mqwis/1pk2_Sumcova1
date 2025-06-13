namespace _1pk2_Sumcova1.Lesson_05.task_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                }
            }
            int min = arr[0, 0];
            for (int i = 0;i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            for(int i = 0; i<n; i++)
            {
                for( int j = 0; j < n; j++)
                {
                    arr[i, j] = arr[i, j] * min;
                }
            }

            int[] max = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = arr[i, j];
                    for (int k = 0; k < 5; k++)
                    {
                        if (num > max[k])
                        {
                            for (int l = 4; l > k; l--)
                            {
                                max[l] = max[l - 1];
                            }
                            max[k] = num;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool maxing = false;
                    for(int k = 0; k < 5; k++)
                    {
                        if(arr[i, j] == max[k])
                        {
                            maxing = true;
                        }
                    }
                    if (maxing)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(arr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
