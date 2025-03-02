const User = require("../Models/User");
const ErrorApp = require("../Error");
const getAll = async (req, res, nxt) => {
  const users = await User.find();
  if (!users.length) return nxt(new ErrorApp("Not Found", 404));
  res.status(201).json({ users });
};

module.exports = { getAll };
