using System.Security.Cryptography.X509Certificates;
using task_12_02;

internal class Program
{
    static void Main(string[] args)
    {
      Cat cat = new Cat();
        cat.name = "Буся";
        cat.breed = "Британская вислоухая";
        cat.weight = 3.5;
        cat.height = 100;

        cat.CatInfo();

        Dog dog = new Dog();
        dog.name = "Луна";
        dog.breed = "Золотистый ретривер";
        dog.weight = 30;
        dog.height = 55;

        dog.DogInfo();
    }
}
