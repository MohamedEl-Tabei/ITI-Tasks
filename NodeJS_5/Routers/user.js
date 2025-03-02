const router = require("express").Router();
const Controller = {
  ...require("../Controller/user"),
  ...require("../Authentication"),
};
router.route("/").get(Controller.getAll);
router.route("/signup").post(Controller.signUp);
module.exports = router;
