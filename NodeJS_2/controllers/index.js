const utilities = require("../utilities");
const fs = require("fs");
const home = (req, res) => {
  // why ./ not ../ ?????
  let homeView = fs.readFileSync("./view/home.html");
  res.end(homeView);
};
const getAll = (req, res) => {
  const data = utilities.listAll();
  let tbody = "";
  data.forEach((element) => {
    tbody = `
      ${tbody}
      <tr>
        <td>${element.id}</td>
        <td>${element.name}</td>
        <td>${element.phone}</td>
        <td>${element.email}</td>
      </tr>
    `;
  });
  const getAllView = fs.readFileSync("./view/getAll.html", "utf8");
  res.end(getAllView.replaceAll("tableBody", tbody));
};
const addNew = (req, res) => {
  req.on("data", (data) => {
    try {
      const obj = JSON.parse(data);
      utilities.add(obj);
      res.end("ok");
    } catch (error) {
      res.statusCode = 400;
      res.end(error);
    }
  });
};
const notFound = (req, res) => {
  res.statusCode = 404;
  res.end("Not Found");
};
module.exports = { home, getAll, addNew, notFound };
