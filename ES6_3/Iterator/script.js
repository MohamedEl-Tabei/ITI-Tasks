const obj = { name: "abc", age: 20 };
function* objIterator() {
  let keys = Object.keys(this);
  let values = Object.values(this);
  for (let i = 0; i < keys.length; i++) {
    yield [keys[i], values[i]];
  }
}
obj[Symbol.iterator] = objIterator;
console.log(...obj);

for (let kv of obj) console.log(kv);
