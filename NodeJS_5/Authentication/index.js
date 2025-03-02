const ErrorApp = require("../Error");
const User = require("../Models/User");
const signUp = async (req, res, nxt) => {
  try {
    await User.create({ ...req.body });
    res.status(200).json({
      data: req.body,
    });
  } catch (error) {
    nxt(new ErrorApp(error.messages, 400));
  }
};

module.exports = {
  signUp,
};
