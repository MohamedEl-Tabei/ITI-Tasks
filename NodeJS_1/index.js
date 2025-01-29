const process = require("process");
const commandArray = process.argv.slice(2, process.argv.length);
let obj = {};
const keys = ["name", "phone", "email"];
const operations = ["add", "delete", "list", "search", "help", "edit"];
const operation = commandArray[0].toLowerCase();
const fs = require("fs");
const fileName = "data.json";
const buffer = fs.readFileSync(fileName);
const data = JSON.parse(buffer);
/* ------------------------------- validation ------------------------------- */
const isValidKey = (key) => {
  if (
    !(keys.includes(key.toLowerCase()) && obj[key.toLowerCase()] == undefined)
  )
    throw "invalid key";
};

const isValidOperation = () => {
  if (!operations.includes(operation)) throw "invalid operation";
};

const isValidEmail = (email) => {
  if (!/^[a-zA-Z][a-zA-Z0-9_-]*@[a-zA-Z]+\.[a-zA-Z]{2,}$/.test(email))
    throw "invalid email";
};

const isValidPhone = (phone) => {
  if (!/^[0][1][0125][0-9]{8}$/.test(phone)) throw "invalid phone";
};

const isValidName = (name) => {
  if (!/^[a-zA-Z]+$/.test(name)) throw "invalid name";
};
/* --------------------- convert commend array to object -------------------- */
const convertToObject = () => {
  for (let i = 1; i < commandArray.length; i++) {
    let key = commandArray[i];
    let value = commandArray[++i];
    isValidKey(key);
    obj[key] = value;
  }
};
/* ---------------------------- operation methods --------------------------- */
const add = () => {
  keys.forEach((key) => {
    if (!obj[key]) throw `invalid command ${key} is required`;
  });
  isValidEmail(obj.email);
  isValidPhone(obj.phone);
  isValidName(obj.name);
  data.push(obj);
  fs.writeFileSync("data.json", JSON.stringify(data));
};

const listAll = () => {
  console.table(data);
};

const search = (key, value, console_log) => {
  console.log(key, value);
  let d = data.filter(
    (user) => user[key].toLowerCase() == value?.toLowerCase()
  );
  if (console_log) console.table(d);
  return d;
};
const delette = (key, value) => {
  let d = search(key, value, false);
  let newData = [];
  while (data.length) {
    let obje = data.pop();
    if (!d.includes(obje)) newData.push(obje);
  }
  fs.writeFileSync(fileName, JSON.stringify(newData));
};

const help = () => {
  operations.forEach((operation) => {
    console.log(`npm run dev ${operation}`);
  });
};

const edit = (key, value, editedKey, newValue) => {
  switch (editedKey.toLowerCase()) {
    case "name":
      isValidName(newValue);
      break;
    case "email":
      isValidEmail(newValue);
      break;
    case "phone":
      isValidPhone(newValue);
      break;
  }
  data.forEach((user) => {
    if (user[key] == value) {
      user[editedKey] = newValue;
    }
  });
  fs.writeFileSync("data.json", JSON.stringify(data));
};
/* ----------------------------------- run ---------------------------------- */
try {
  convertToObject();
  isValidOperation();
  switch (operation) {
    case "add":
      add();
      break;
    case "list":
      listAll();
      break;
    case "search":
      search(commandArray[1], obj[commandArray[1]], true);
      break;
    case "delete":
      delette(commandArray[1], obj[commandArray[1]].toLowerCase());
      break;
    case "help":
      help();
      break;
    case "edit":
      edit(
        commandArray[1],
        obj[commandArray[1]],
        commandArray[3],
        obj[commandArray[3]]
      );
  }
} catch (error) {
  console.log(error);
}
