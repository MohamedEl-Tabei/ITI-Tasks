const mongoose = require("mongoose");
const schema = {
  title: {
    type: String,
    minLength: [3, "Title must be more than 3 characters"],
  },
  isDone: {
    type: Boolean,
    required: true,
  },
  duration: {
    type: String,
    enum: ["1d", "1w"],
  },
  userId: {
    ref: "User",
    type: mongoose.SchemaTypes.ObjectId,
  },
};
const Schema = new mongoose.Schema(schema);

module.exports = mongoose.model("Task", Schema);
