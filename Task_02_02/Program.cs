namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8; // вводим первую переменную
            double b = 14; // вводим вторую переменную 
            double c = Math.PI / 4; // вводим третью переменную
            double result = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3), 0.25) / (Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c))); // решаем числитель и знаменатель
            Console.WriteLine(result); // вводим команду для результата

        }
    }
}
