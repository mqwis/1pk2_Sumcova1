namespace _1pk2_Sumcova1.Lesson_05.task_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5]
            {
                {0,-1,-2,-3,-4},
                {-1,0,-2,-3,-4},
                {-1,-2,0,-3,-4},
                {-1,-2,-3,0,-4},
                {-1,-2,-3,-4,0}
            };

            int count = 0; 
            for (int i = 0; i < 5; i ++)
            {
                for (int j= 0; j <5; j ++)
                {
                    if (i != j)
                    {
                        if (arr[i, j] < 0)
                        {
                            count++;
                        }
                    }
                }

            }

            if (count == 20)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == j)
                        {
                            if (arr[i, j] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(arr[i, j] + " " + '\t');
                                Console.ResetColor();
                            }
                            
                            
                        }
                        else
                        {
                            Console.Write(arr[i, j] + " " + '\t');
                        }
                    }
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Матрица не является z матрицей");
            }
        }
    }
}
