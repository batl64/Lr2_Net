// Component
class Component {
  constructor(name) {
    this.name = name;
  }

  operation() {
    throw new Error("This method must be overridden!");
  }

  add(component) {
    throw new Error("This method must be overridden!");
  }

  remove(component) {
    throw new Error("This method must be overridden!");
  }

  getChild(index) {
    throw new Error("This method must be overridden!");
  }
}

// Leaf
class Leaf extends Component {
  constructor(name) {
    super(name);
  }

  operation() {
    console.log(`Leaf ${this.name} operation`);
  }
}

// Composite
class Composite extends Component {
  constructor(name) {
    super(name);
    this.children = [];
  }

  operation() {
    console.log(`Composite ${this.name} operation`);
    for (let child of this.children) {
      child.operation();
    }
  }

  add(component) {
    this.children.push(component);
  }

  remove(component) {
    this.children = this.children.filter((child) => child !== component);
  }

  getChild(index) {
    return this.children[index];
  }
}

// Client
class Client {
  constructor(component) {
    this.component = component;
  }

  run() {
    this.component.operation();
  }
}

// Usage
const leaf1 = new Leaf("leaf1");
const leaf2 = new Leaf("leaf2");
const leaf3 = new Leaf("leaf3");

const composite1 = new Composite("composite1");
const composite2 = new Composite("composite2");

composite1.add(leaf1);
composite1.add(leaf2);
composite2.add(leaf3);

composite1.add(composite2);

const client = new Client(composite1);
client.run();
