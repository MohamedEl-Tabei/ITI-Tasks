const validation = require("../validation");
const fs = require("fs");
const fileName = "data.json";
const buffer = fs.readFileSync(fileName);
const data = JSON.parse(buffer);

const add = (obj) => {
  let id = 1;
  validation.email(obj.email);
  validation.phone(obj.phone);
  validation.name(obj.name);
  for (let i = 0; i < data.length; i++) {
    id = Math.max(id, data[i].id) + 1;
  }
  obj.id = id;
  data.push(obj);
  fs.writeFileSync("data.json", JSON.stringify(data));
};

const listAll = () => {
  return data;
};

const search = (key, value) => {
  let d = data.filter(
    (user) => user[key].toLowerCase() == value?.toLowerCase()
  );
  return d;
};
const delette = (key, value) => {
  let newData = data.filter(
    (user) => user[key].toLowerCase() != value?.toLowerCase()
  );
  fs.writeFileSync(fileName, JSON.stringify(newData));
};

const edit = (key, value, editedKey, newValue) => {
  switch (editedKey.toLowerCase()) {
    case "name":
      validation.name(newValue);
      break;
    case "email":
      validation.email(newValue);
      break;
    case "phone":
      validation.phone(newValue);
      break;
  }
  data.forEach((user) => {
    if (user[key] == value) {
      user[editedKey] = newValue;
    }
  });
  fs.writeFileSync("data.json", JSON.stringify(data));
};
module.exports = {
  add,
  edit,
  delette,
  listAll,
  search,
};
