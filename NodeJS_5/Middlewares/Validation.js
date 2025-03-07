const AppError = require("../Error");
const Validation = require("../Validation");
const SignUp = async (req, res, nxt) => {
  try {
    await Validation.SignUp.validateAsync({ ...req.body });
    nxt();
  } catch (err) {
    nxt(new AppError(err.message, 400));
  }
};
const Login = async (req, res, nxt) => {
  try {
    await Validation.Login.validateAsync({ ...req.body });
    nxt();
  } catch (err) {
    nxt(new AppError(err.message, 400));
  }
};
const AddTask = async (req, res, nxt) => {
  try {
    const { userId, title, isDone, duration } = req.body;

    await Validation.AddTask.validateAsync({ userId, title, isDone, duration });

    nxt();
  } catch (err) {
    nxt(new AppError(err.message, 400));
  }
};

module.exports = { SignUp, Login, AddTask };
