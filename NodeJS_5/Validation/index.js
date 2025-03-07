const Joi = require("joi");

const SignUp = Joi.object({
  name: Joi.string().min(3).required(),
  email: Joi.string().email().required(),
  password: Joi.string().required().min(8),
  isAdmin: Joi.bool(),
});
const Login = Joi.object({
  email: Joi.string().email().required(),
  password: Joi.string().required(),
});

const AddTask = Joi.object({
  title: Joi.string().min(3).required(),
  isDone: Joi.bool().required(),
  duration: Joi.required(),
  userId: Joi.required(),
});
module.exports = { SignUp, Login, AddTask };
