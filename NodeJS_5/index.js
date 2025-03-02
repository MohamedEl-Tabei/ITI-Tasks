const app = require("./App");
const mongoose = require("mongoose");
require("dotenv").config();

app.listen(process.env.PORT || 5000, () => {
  console.log("server started");
});

mongoose.connect(process.env.MONGODBURI).then(() => {
  console.log("DB connected");
});
