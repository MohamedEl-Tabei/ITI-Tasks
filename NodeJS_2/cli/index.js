const utilities = require("../utilities");
const process = require("process");
const commandArray = process.argv.slice(2, process.argv.length);
let obj = {};
const keys = ["name", "phone", "email"];
const operations = ["add", "delete", "list", "search", "help", "edit"];
const operation = commandArray[0].toLowerCase();

const convertToObject = () => {
  for (let i = 1; i < commandArray.length; i++) {
    let key = commandArray[i];
    let value = commandArray[++i];
    if (
      !keys.includes(key.toLowerCase()) ||
      obj[key.toLowerCase()] != undefined
    )
      throw "invalid key";
    obj[key] = value;
  }
};
const help = () => {
  operations.forEach((operation) => {
    console.log(`npm run dev ${operation}`);
  });
};
const CLI = () => {
  try {
    convertToObject();
    if (!operations.includes(operation)) throw "invalid operation";
    switch (operation) {
      case "add":
        utilities.add(obj);
        break;
      case "list":
        console.table(utilities.listAll());
        break;
      case "search":
        console.table(utilities.search(commandArray[1], obj[commandArray[1]]));
        break;
      case "delete":
        utilities.delette(commandArray[1], obj[commandArray[1]].toLowerCase());
        break;
      case "help":
        help();
        break;
      case "edit":
        utilities.edit(
          commandArray[1],
          obj[commandArray[1]],
          commandArray[3],
          obj[commandArray[3]]
        );
    }
  } catch (error) {
    console.log(error);
  }
};
module.exports = CLI;
