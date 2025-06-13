namespace _1pk2_Sumcova1.Lesson_11.task_11_03
{
    internal class Program
    {
        static void CountVowelsAndConsonants(string text, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;

            // приводим строку к нижнему регистру для удобства проверки
            string lowerText = text.ToLower();

            foreach (char c in lowerText)
            {
                if (char.IsLetter(c))
                {
                    if ("аеёиоуыэюяaeiou".Contains(c)) // проверяем, является ли символ гласной
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
        }
    }
}
