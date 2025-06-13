// Создаем пользователей
using task_14_04;

User user1 = new User("Alice", 1);
User user2 = new User("Bob", 2);

// Устанавливаем текущего пользователя
User.SetCurrentUser(user1);

// Выводим информацию о текущем пользователе
if (User.CurrentUser != null)
{
    User.CurrentUser.PrintInfo();
}

// Меняем текущего пользователя
User.SetCurrentUser(user2);

// Выводим информацию о новом текущем пользователе
if (User.CurrentUser != null)
{
    User.CurrentUser.PrintInfo();
}

// Попытка установить текущего пользователя как null
try
{
    User.SetCurrentUser(null); // Выбросит исключение
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
