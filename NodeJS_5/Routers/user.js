const router = require("express").Router();
const Controller = {
  ...require("../Controller/user"),
  ...require("../Authentication"),
};
const Middleware = {
  Validation: require("../Middlewares/Validation"),
};

router.route("/").get(Controller.getAll);
router.route("/signup").post(Middleware.Validation.SignUp, Controller.signUp);
router.route("/login").post(Middleware.Validation.Login, Controller.login);
module.exports = router;
