namespace _1pk2_Sumcova1.Lesson_11.task_11_02
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Inside Swap: a = {a}, b = {b}");
        }

        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            Swap(ref x, ref y); // Передаём по ссылке
            Console.WriteLine($"After Swap: x = {x}, y = {y}");
        }
    }
}
