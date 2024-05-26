// State
class State {
  constructor() {}

  handle(context) {
    throw new Error("This method must be overridden!");
  }
}

// ConcreteState A
class ConcreteStateA extends State {
  constructor() {
    super();
  }

  handle(context) {
    console.log("Handling request in state A");
    context.state = new ConcreteStateB();
  }
}

// ConcreteState B
class ConcreteStateB extends State {
  constructor() {
    super();
  }

  handle(context) {
    console.log("Handling request in state B");
    context.state = new ConcreteStateA();
  }
}

// Context
class Context {
  constructor() {
    this.state = new ConcreteStateA();
  }

  request() {
    this.state.handle(this);
  }
}

// Usage
const context = new Context();
context.request();
context.request();
context.request();
