// Prototype
class Prototype {
  clone() {
    throw new Error("This method must be overridden!");
  }
}

// ConcretePrototype
class ConcretePrototype extends Prototype {
  constructor(property) {
    super();
    this.property = property;
  }

  clone() {
    return new ConcretePrototype(this.property);
  }

  getProperty() {
    return this.property;
  }

  setProperty(value) {
    this.property = value;
  }
}

// Client
class Client {
  constructor(prototype) {
    this.prototype = prototype;
  }

  operation() {
    const clonedObject = this.prototype.clone();
    console.log("Cloned object property:", clonedObject.getProperty());
  }
}

// Usage
const concretePrototype = new ConcretePrototype("Initial value");
const client = new Client(concretePrototype);

client.operation();

const clonedObject = concretePrototype.clone();
clonedObject.setProperty("Modified value");

console.log("Original object property:", concretePrototype.getProperty());
console.log("Modified cloned object property:", clonedObject.getProperty());
