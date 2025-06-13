using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14_04
{
    class User
    {
        // Свойства пользователя
        public string Username { get; private set; } // Имя пользователя
        public int Id { get; private set; } // Уникальный идентификатор пользователя

        // Статическое свойство для хранения текущего пользователя
        public static User CurrentUser { get; private set; }

        // Конструктор для создания пользователя
        public User(string username, int id)
        {
            Username = username;
            Id = id;
        }

        // Статический метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "Пользователь не может быть null.");
            }

            CurrentUser = user;
            Console.WriteLine($"Текущий пользователь изменен: {user.Username} (ID: {user.Id})");
        }

        // Метод для вывода информации о пользователе
        public void PrintInfo()
        {
            Console.WriteLine($"Пользователь: {Username}, ID: {Id}");
        }
    }
}
