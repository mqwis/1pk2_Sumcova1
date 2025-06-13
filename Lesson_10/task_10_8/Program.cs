namespace task_10_8
{
    internal class Program
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 3;

            int index = FindIndex(array, target);

            Console.WriteLine("Индекс элемента: " + index);
        }

        public static int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1; // если элемент не найден
        }
    }
}
