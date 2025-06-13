namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = ""; // вводим переменную строки
            int num = 0; // вводим переменную числа

            while (true)
            {
                str = Console.ReadLine();
                num = num + 1; // вводим формулу для num 
                if (str == "exit" || str == "") // вводим условие из задачи
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
