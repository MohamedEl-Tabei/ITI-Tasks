const controller = require("../controllers/usser");
const router = require("express").Router();

router.get("/", controller.getAllUsers);
router.post("/", controller.addUser);

module.exports = router;
