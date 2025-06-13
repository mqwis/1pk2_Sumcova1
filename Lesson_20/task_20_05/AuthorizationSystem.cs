using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_05
{
    internal class AuthorizationSystem
    {
        public enum AccessLevel
        {
            Guest,      // Только чтение
            User,       // Чтение + Комментарии
            Moderator,  // Удаление контента
            Admin       // Полный доступ
        }


        // Метод для проверки прав доступа
        public bool CanPerformAction(AccessLevel userAccessLevel, AccessLevel requiredAccessLevel)
        {
            return userAccessLevel >= requiredAccessLevel;
        }


        // Метод для удаления поста (имитация действия)
        public void DeletePost(AccessLevel userAccessLevel)
        {
            if (CanPerformAction(userAccessLevel, AccessLevel.Moderator))
            {
                Console.WriteLine("Пост успешно удален.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для удаления поста.");
            }
        }

        // Метод для комментирования (имитация действия)
        public void CommentPost(AccessLevel userAccessLevel)
        {
            if (CanPerformAction(userAccessLevel, AccessLevel.User))
            {
                Console.WriteLine("Комментарий успешно добавлен.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для добавления комментария.");
            }
        }

        // Метод для чтения (имитация действия)
        public void ReadPost(AccessLevel userAccessLevel)
        {
            if (CanPerformAction(userAccessLevel, AccessLevel.Guest))
            {
                Console.WriteLine("Пост прочитан.");
            }
            else
            {
                Console.WriteLine("Ошибка: Невозможно прочитать пост.");
            }
        }
    }
}

