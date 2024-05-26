using System;

// Прототип
abstract class Prototype
{
    public abstract Prototype Clone();
}

// Конкретний прототип
class ConcretePrototype : Prototype
{
    private string _name;

    public ConcretePrototype(string name)
    {
        _name = name;
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype(_name);
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {_name}");
    }
}

// Клієнт
class Client
{
    private Prototype _prototype;

    public Client(Prototype prototype)
    {
        _prototype = prototype;
    }

    public Prototype Operation()
    {
        return _prototype.Clone();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення прототипу
        ConcretePrototype prototype = new ConcretePrototype("Prototype");

        // Клонування прототипу
        ConcretePrototype clone1 = (ConcretePrototype)prototype.Clone();
        clone1.Show(); // Виведе "Name: Prototype"

        // Модифікація клонованого об'єкта
        clone1.SetName("Modified Prototype");
        clone1.Show(); // Виведе "Name: Modified Prototype"

        // Клонування прототипу через клієнт
        Client client = new Client(prototype);
        ConcretePrototype clone2 = (ConcretePrototype)client.Operation();
        clone2.Show(); // Виведе "Name: Prototype"
    }
}
