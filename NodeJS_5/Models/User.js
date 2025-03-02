const mongoose = require("mongoose");
const schema = {
  name: {
    required: "Name is required.",
    type: String,
    minLength: [3, "Name length must be 3 or more."],
  },
  email: {
    required: "Email is required.",
    unique: true,
    type: String,
  },
  password: {
    required: "Password is required.",
    type: String,
    minLength: [8, "Password length must be 8 or more."],
  },
};

const Schema = new mongoose.Schema(schema);
module.exports = mongoose.model("User", Schema);
