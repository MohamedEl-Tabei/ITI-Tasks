// a∙ name property that accepts only string of 7 characters.

// b∙ address property that accepts only string value.

// c∙ age property that accepts numerical value between 25 and 60.
const obj = { name: "", address: "", age: 0 };

const proxyHandler = {
  set: (target, prop, value, prox) => {
    //target=obj
    //prop=targetProperty
    //prox= {target , handler}
    if (!target.hasOwnProperty(prop)) throw "Invalid property";
    switch (prop) {
      case "name":
        if (value.length != 7 || typeof value != "string") throw "Invalid name";
        break;
      case "address":
        if (typeof value != "string") throw "Invalid address";
        break;
      case "age":
        if (typeof value != "number" || value < 25 || value > 60)
          throw "Invalid age";
        break;
      default:
        break;
    }
    target[prop] = value;
  },
};
let prox = new Proxy(obj, proxyHandler);
prox.name = "1234567";
// prox.age = 12;
// prox.address = 12;
console.log(prox.name);
