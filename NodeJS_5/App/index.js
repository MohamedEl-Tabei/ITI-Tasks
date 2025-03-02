const express = require("express");
const app = express();
const routers = {
  user: require("../Routers/user"),
};
const middlewares = {
  Error: require("../Middlewares/ErrorHandler"),
};
app.use(express.json());

app.use("/users", routers.user);
app.use(middlewares.Error);
module.exports = app;
