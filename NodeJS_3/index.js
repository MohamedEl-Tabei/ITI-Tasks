const router = {
  user: require("./routers/user"),
  product: require("./routers/product"),
};
const express = require("express");
let app = express();
app.use(express.json());
app.use("/product", router.product);
app.use("/user", router.user);

app.listen(3001, () => console.log("server is on"));
