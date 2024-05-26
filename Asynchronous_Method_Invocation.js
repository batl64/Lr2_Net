// Receiver
class Receiver {
  async receiveAsync() {
    await new Promise((resolve) => setTimeout(resolve, 1000));
    return "Data from receiver";
  }
}

// Callback
class Callback {
  onComplete(data) {
    console.log(`Received data: ${data}`);
  }
}

// Invoker
class Invoker {
  constructor(receiver, callback) {
    this.receiver = receiver;
    this.callback = callback;
  }

  async invokeAsync() {
    const data = await this.receiver.receiveAsync();
    this.callback.onComplete(data);
  }
}

// Client
class Client {
  constructor(invoker) {
    this.invoker = invoker;
  }

  async runAsync() {
    await this.invoker.invokeAsync();
  }
}

// Usage
const receiver = new Receiver();
const callback = new Callback();
const invoker = new Invoker(receiver, callback);
const client = new Client(invoker);

client.runAsync();
