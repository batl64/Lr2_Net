using System;
using System.Collections.Generic;

// Компонент
abstract class Component
{
    protected string _name;

    public Component(string name)
    {
        _name = name;
    }

    public abstract void Operation();
}

// Лист
class Leaf : Component
{
    public Leaf(string name) : base(name) { }

    public override void Operation()
    {
        Console.WriteLine($"Leaf {_name} operation");
    }
}

// Композит
class Composite : Component
{
    private List<Component> _children = new List<Component>();

    public Composite(string name) : base(name) { }

    public void Add(Component component)
    {
        _children.Add(component);
    }

    public void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override void Operation()
    {
        Console.WriteLine($"Composite {_name} operation");
        foreach (var child in _children)
        {
            child.Operation();
        }
    }
}

// Клієнт
class Client
{
    private Component _component;

    public Client(Component component)
    {
        _component = component;
    }

    public void Run()
    {
        _component.Operation();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення листків
        Leaf leaf1 = new Leaf("leaf1");
        Leaf leaf2 = new Leaf("leaf2");
        Leaf leaf3 = new Leaf("leaf3");

        // Створення композитів
        Composite composite1 = new Composite("composite1");
        Composite composite2 = new Composite("composite2");

        // Додавання листків до композитів
        composite1.Add(leaf1);
        composite1.Add(leaf2);
        composite2.Add(leaf3);

        // Додавання композитів до іншого композиту
        composite1.Add(composite2);

        // Створення клієнта з кореневим композитом і запуск операції
        Client client = new Client(composite1);
        client.Run();


    }
}