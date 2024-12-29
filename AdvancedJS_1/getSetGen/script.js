//i.e. if you have the following object
var obj = {
  id: "SD-10",
  location: "SV",
  addr: "123 st.",
  getSetGen: function () {
    //should be implemented
    var keys = Object.keys(this);// get keys of object
    var self = this; // to access caller not widow
    keys.forEach(function (key) {
      var value = self[key]; // to avoid stack error 
      if (typeof self[key] != "function") {
        Object.defineProperty(self, key, {
          get: function () {
            return value;
          },
          set: function (v) {
             value=v;
          },
        });
      }
    });
  },
};

obj.getSetGen();
obj.addr = 5;
console.log(obj);
var user = { name: "Ali", age: 10 };
obj.getSetGen.call(user)
console.log(user);
