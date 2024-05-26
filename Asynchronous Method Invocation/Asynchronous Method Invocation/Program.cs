using System;
using System.Threading.Tasks;

// Receiver
class Receiver
{
    public async Task<string> ReceiveAsync()
    {
        await Task.Delay(1000); // імітуємо деяку асинхронну роботу
        return "Data from receiver";
    }
}

// Callback
class Callback
{
    public void OnComplete(string data)
    {
        Console.WriteLine($"Received data: {data}");
    }
}

// Invoker
class Invoker
{
    private Receiver _receiver;
    private Callback _callback;

    public Invoker(Receiver receiver, Callback callback)
    {
        _receiver = receiver;
        _callback = callback;
    }

    public async Task InvokeAsync()
    {
        string data = await _receiver.ReceiveAsync();
        _callback.OnComplete(data);
    }
}

// Client
class Client
{
    private Invoker _invoker;

    public Client(Invoker invoker)
    {
        _invoker = invoker;
    }

    public async Task RunAsync()
    {
        await _invoker.InvokeAsync();
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        Receiver receiver = new Receiver();
        Callback callback = new Callback();
        Invoker invoker = new Invoker(receiver, callback);
        Client client = new Client(invoker);

        await client.RunAsync();
    }
}
