using System;

// Контекст
class Context
{
    private State _state;

    public Context()
    {
        // Початковий стан
        _state = new ConcreteStateA();
    }

    public void Request()
    {
        _state.Handle(this);
    }

    public State State
    {
        get { return _state; }
        set { _state = value; }
    }
}

// Стан
abstract class State
{
    public abstract void Handle(Context context);
}

// Конкретний стан A
class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Handling request in state A");
        context.State = new ConcreteStateB();
    }
}

// Конкретний стан B
class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Handling request in state B");
        context.State = new ConcreteStateA();
    }
}

// Клієнт
class Client
{
    private Context _context;

    public Client(Context context)
    {
        _context = context;
    }

    public void Run()
    {
        _context.Request();
        _context.Request();
        _context.Request();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Context context = new Context();
        Client client = new Client(context);

        client.Run();
    }
}
