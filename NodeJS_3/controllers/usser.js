const fs = require("fs");
const getData = () => {
  const data = fs.readFileSync("./data.json");
  return JSON.parse(data);
};
const getAllUsers = (req, res) => {
  res.send(JSON.stringify(getData()));
};

const addUser = (req, res) => {
  const data = getData();
  data.push(req.body);
  console.log(data);
  fs.writeFileSync("./data.json", JSON.stringify(data));
  res.send("ok");
};

module.exports = { getAllUsers, addUser };
