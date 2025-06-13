using static task_20_05.AuthorizationSystem;
using task_20_05;

AuthorizationSystem authSystem = new AuthorizationSystem();

// Пример использования
AccessLevel userLevel1 = AccessLevel.Guest;
authSystem.ReadPost(userLevel1);     // Должен сработать
authSystem.CommentPost(userLevel1);  // Должен вывести ошибку
authSystem.DeletePost(userLevel1);   // Должен вывести ошибку
Console.WriteLine();


AccessLevel userLevel2 = AccessLevel.User;
authSystem.ReadPost(userLevel2);     // Должен сработать
authSystem.CommentPost(userLevel2);  // Должен сработать
authSystem.DeletePost(userLevel2);   // Должен вывести ошибку
Console.WriteLine();


AccessLevel userLevel3 = AccessLevel.Moderator;
authSystem.ReadPost(userLevel3);     // Должен сработать
authSystem.CommentPost(userLevel3);  // Должен сработать
authSystem.DeletePost(userLevel3);   // Должен сработать
Console.WriteLine();


AccessLevel userLevel4 = AccessLevel.Admin;
authSystem.ReadPost(userLevel4);     // Должен сработать
authSystem.CommentPost(userLevel4);  // Должен сработать
authSystem.DeletePost(userLevel4);   // Должен сработать
Console.WriteLine();
        