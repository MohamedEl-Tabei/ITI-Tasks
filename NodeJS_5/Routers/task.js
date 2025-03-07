const express = require("express");
const router = express.Router();
const Middleware = {
  Authorization: require("../Middlewares/Authorization"),
  Validation: require("../Middlewares/Validation"),
};
const Controller = require("../Controller/task");
router
  .route("/create")
  .post(
    Middleware.Authorization,
    Middleware.Validation.AddTask,
    Controller.addNewTask
  );
router
  .route("/delete/:id")
  .delete(Middleware.Authorization, Controller.deleteTask);
router
  .route("/update/:id")
  .put(Middleware.Authorization, Controller.updateTask);
router.route("/:id").get(Middleware.Authorization, Controller.getTask);
router.route("/").get(Middleware.Authorization, Controller.getTasks);

module.exports = router;
