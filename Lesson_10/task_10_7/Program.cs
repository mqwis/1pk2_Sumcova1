namespace task_10_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // запрашиваем у пользователя размерность массива
            Console.WriteLine("Введите размерность массива (n):");
            int n = int.Parse(Console.ReadLine());

            // генерируем массив
            char[,] array = GenerateRussianAlphabetArray(n);

            // выводим массив на консоль
            PrintArray(array);
        }
        static char[,] GenerateRussianAlphabetArray(int n)
        {
            char[,] array = new char[n, n];
            Random random = new Random();

            // начальный символ русского алфавита (А)
            char startChar = 'А';

            // заполняем массив символами русского алфавита
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // генерируем случайный символ из русского алфавита
                    array[i, j] = (char)(startChar + random.Next(0, 32)); // 32 символа в русском алфавите
                }
            }

            return array;
        }

        // метод для вывода двумерного массива на консоль
        static void PrintArray(char[,] array)
        {
            int n = array.GetLength(0); // получаем размерность массива

            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t"); // вывод с табуляцией для красоты
                }
                Console.WriteLine(); // вереход на новую строку после каждой строки массива
            }
        }
    }
}