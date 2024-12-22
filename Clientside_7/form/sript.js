//variables
var name;
var age = "";
var email;
var arr = [];

//selectors
var errName = document.getElementById("nameError");
var errAge = document.getElementById("ageError");
var errEmail = document.getElementById("emailError");
var iName = document.getElementById("name");
var iAge = document.getElementById("age");
var iEmail = document.getElementById("email");
var tbody = document.getElementById("container");
var addBtn = document.getElementById("add");
var resetBtn = document.getElementById("reset");
var tableContainer = document.getElementsByClassName("table-container")[0];

//validition
var nameValidation = function (value) {
  try {
    if (value.length < 3) throw "Name length must be more than or equel 3";
    if (value.length > 20) throw "Name length must be less than or equel 20";
    if (!/^[a-zA-Z\s]+$/.test(value))
      throw "Name must contain only characters a-z";
    errName.innerText = "";
    name = value;
  } catch (error) {
    errName.innerText = error;
  }
};

var ageValidation = function (value) {
  try {
    if (value > 60) throw "Max age is 60";
    if (value < 20) throw "Min age is 20";
    errAge.innerText = "";
    age = value;
  } catch (error) {
    errAge.innerText = error;
  }
};

var emailValidation = function (value) {
  try {
    if (!/^[a-zA-Z][a-zA-Z0-9_.]+@[a-zA-Z]+\.[a-zA-Z]{2,}$/.test(value)) throw "Invalid email";
   
    errEmail.innerText = "";
    email = value;
  } catch (error) {
    errEmail.innerText = error;
  }
};

//
var onInputHandler = function (event) {
  var target = event.target;
  var id = target.id;
  switch (id) {
    case "name":
      nameValidation(target.value);
      break;
    case "age":
      if (!/^[0-9]+$/.test(target.value) && target.value != "")
        target.value = age;
      else ageValidation(target.value);
      age=target.value
      break;
    case "email":
      emailValidation(target.value);
      break;
  }
  if (errName.innerText || errAge.innerText || errEmail.innerText)
    addBtn.style.cursor = "not-allowed";
  else {
    addBtn.style.cursor = "pointer";
    resetBtn.style.cursor = "pointer";
  }
};
addBtn.addEventListener("click", function () {
  if (addBtn.style.cursor == "pointer") {
    arr.push({ age, name, email });
    var tr = document.createElement("tr");
    tr.innerHTML =
      "<td>" +
      name +
      "</td>" +
      "<td>" +
      age +
      "</td>" +
      "<td>" +
      email +
      "</td>";
    tbody.append(tr);
    tableContainer.style.visibility = "visible";
    age = "";
    name = "";
    email = "";
    iAge.value = "";
    iName.value = "";
    iEmail.value = "";
    addBtn.style.cursor = "not-allowed";
    resetBtn.style.cursor = "not-allowed";
  }
});

resetBtn.addEventListener("click", function () {
  age = "";
  name = "";
  email = "";
  iAge.value = "";
  iName.value = "";
  iEmail.value = "";
  addBtn.style.cursor = "not-allowed";
  resetBtn.style.cursor = "not-allowed";
  errAge.innerText = "";
  errEmail.innerText = "";
  errName.innerText = "";
});

iName.addEventListener("input", onInputHandler);
iAge.addEventListener("input", onInputHandler);
iEmail.addEventListener("input", onInputHandler);
//
