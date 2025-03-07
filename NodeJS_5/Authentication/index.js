const ErrorApp = require("../Error");
const User = require("../Models/User");
const JWT = require("jsonwebtoken");
const bcrypt = require("bcrypt");
const signUp = async (req, res, nxt) => {
  try {
    const newUser = await User.create({ ...req.body });
    const token = await JWT.sign(
      { userId: newUser.id, isAdmin: newUser.isAdmin },
      process.env.SECRETKEY
    );
    res.status(200).header({ token }).json({ user: newUser });
  } catch (error) {
    nxt(new ErrorApp(error.message, 400));
  }
};
const login = async (req, res, nxt) => {
  try {
    const user = await User.findOne({ email: req.body.email });
    if (!user || !(await bcrypt.compare(req.body.password, user.password)))
      throw Error("Invalid email or password");
    const token = await JWT.sign(
      { userId: user.id, isAdmin: user.isAdmin },
      process.env.SECRETKEY
    );
    res
      .status(200)
      .header({ token })
      .json({ ...user._doc, password: undefined });
  } catch (error) {
    nxt(new ErrorApp(error.message, 400));
  }
};

module.exports = {
  signUp,
  login,
};
