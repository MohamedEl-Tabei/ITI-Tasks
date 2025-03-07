const JWT = require("jsonwebtoken");
const AppError = require("../Error");

const Authorization = async (req, res, nxt) => {
  try {
    const data = await JWT.verify(req.headers.token, process.env.SECRETKEY);
    req.body = { ...data, ...req.body };
    nxt();
  } catch (error) {
    nxt(new AppError(error.message, 401));
  }
};

module.exports = Authorization;
