namespace task_12_02;

public class Dog
{
    public string name; // поле класса - хранит имя
    public string breed; // поле класса - хранит породу
    public double weight; // поле класса - хранит вес
    public int height; // поле класса - хранит рост

    public void DogInfo()
    {
        Console.WriteLine($"Собака '{name}', породы {breed}\nВесом - {weight} кг\nРостом - {height} см");
    }
}