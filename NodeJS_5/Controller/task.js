const AppError = require("../Error");
const Task = require("../Models/Task");
const addNewTask = async (req, res, nxt) => {
  try {
    const newTask = await Task.create({ ...req.body });
    res.status(201).json({ newTask });
  } catch (error) {
    nxt(new AppError(error.message, 400));
  }
};
const deleteTask = async (req, res, nxt) => {
  try {
    const userId = (await Task.findById(req.params.id)).userId;
    if (userId != req.body.userId && !req.body.isAdmin)
      throw new Error("Not allowed");

    await Task.findByIdAndDelete(req.params.id);
    res.status(201).json({ message: "deleted" });
  } catch (error) {
    nxt(new AppError(error.message, 400));
  }
};
const updateTask = async (req, res, nxt) => {
  try {
    const userId = (await Task.findById(req.params.id)).userId;
    if (userId != req.body.userId) throw new Error("Not allowed");

    await Task.findByIdAndUpdate(req.params.id, { ...req.body });
    res.status(201).json({ message: "updated" });
  } catch (error) {
    nxt(new AppError(error.message, 400));
  }
};
const getTask = async (req, res, nxt) => {
  try {
    const task = await Task.findById(req.params.id);
    const userId = task.userId;
    if (userId != req.body.userId) throw new Error("Not allowed");

    res.status(201).json({ task });
  } catch (error) {
    nxt(new AppError(error.message, 400));
  }
};
const getTasks = async (req, res, nxt) => {
  try {
    const userId = req.body.userId;
    const tasks = await Task.find({ userId });

    res.status(201).json({ tasks });
  } catch (error) {
    nxt(new AppError(error.message, 400));
  }
};
module.exports = {
  addNewTask,
  deleteTask,
  updateTask,
  getTasks,
  getTask,
};
