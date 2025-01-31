const controller = require("../controllers/product");
const router = require("express").Router();
router.get("/", controller.getProduct);
router.post("/", controller.postProduct);

module.exports = router;
