namespace _1pk2_Sumcova1.Lesson_11.task_11_01
{
    internal class Program
    {
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Внутри Swap: a = {a}, b = {b}");
        }

        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До Swap: x = {x}, y = {y}");
            Swap(x, y);
            Console.WriteLine($"После Swap: x = {x}, y = {y}");
        }
    }
}
