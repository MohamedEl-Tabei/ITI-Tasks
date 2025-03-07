const mongoose = require("mongoose");
const bcrypt = require("bcrypt");
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
  isAdmin: {
    default: false,
    type: Boolean,
  },
};

const Schema = new mongoose.Schema(schema);
Schema.pre("save", async function () {
  this.password = await bcrypt.hash(this.password, 10);
});
module.exports = mongoose.model("User", Schema);
