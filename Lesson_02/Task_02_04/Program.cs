namespace _1pk2_Sumcova1.Lesson_02.Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой год рождения: "); // вводим команду для вывода текста в консоль 
            int year = int.Parse(Console.ReadLine()); // вводим переменную года
            Console.WriteLine("Введите свой месяц рождения: "); // вводим команду для вывода текста в консоль
            int month = int.Parse(Console.ReadLine()); // вводим переменную месяца
            Console.WriteLine("Введите свой день рождения: "); // вводим команду для вывода текста в консоль
            int day = int.Parse(Console.ReadLine()); // вводим переменную дня

            DateTime today = DateTime.Now; //Получили текущую дату
            DateTime birthDate = new DateTime(year, month, day); //Создали dateTime на основе введных данных
            int age = today.Year - birthDate.Year; //посчитали возраст
            if (age >= 18) //сравнение поулченного возраста с совершенолетием
                Console.WriteLine("Пользователь совершеннолетний");
            else
                Console.WriteLine("Пользователь несовершеннолетний");
        }
    }
}

