//  "Name", "Email", "Mobile", "Gender", "Address"
//selectors
var selectors = {
  timeout:document.getElementById("timer"),
  form: document.forms[0],
  submitBtn: document.getElementById("submit"),
  name: {
    input: document.getElementById("name"),
    err: document.getElementById("nameError"),
  },
  email: {
    input: document.getElementById("email"),
    err: document.getElementById("emailError"),
  },
  mobile: {
    input: document.getElementById("mobile"),
    err: document.getElementById("mobileError"),
  },
  gender: document.getElementById("gender"),
  address: {
    city: {
      input: document.getElementById("city"),
    },
    street: {
      input: document.getElementById("street"),
    },
    building: {
      input: document.getElementById("building"),
    },
    err: document.getElementById("addressError"),
  },
};
//object user
var user = {
  name: "",
  email: "",
  mobile: "",
  gender: "Male",
  address: { city: "", street: "", building: "" },
};
//functions validation

var nameValidation = function (value) {
  try {
    if (!value) throw "This field is required";
    if (value.length < 3) throw "Name length must be more than or equel 3";
    if (value.length > 20) throw "Name length must be less than or equel 20";
    if (!/^[a-zA-Z\s0-9]+$/.test(value))
      throw "Name must contain only characters a-z and numbers 0-9";
    selectors.name.err.innerText = "";
    user.name = value;
  } catch (error) {
    selectors.name.err.innerText = error;
  }
};

var emailValidation = function (value) {
  try {
    if (!value) throw "This field is required";
    if (!/^[a-zA-Z][a-zA-Z0-9_.]+@[a-zA-Z]+\.[a-zA-Z]{2,}$/.test(value))
      throw "Invalid email";
    selectors.email.err.innerText = "";
    user.email = value;
  } catch (error) {
    selectors.email.err.innerText = error;
  }
};
var mobileValidation = function (value) {
  try {
    if (!value) throw "This field is required";
    if (!/^01(0|1|2|5)[0-9]+$/.test(value) || value.length != 11)
      throw "Invalid mobile number";
    selectors.mobile.err.innerText = "";
    user.mobile = value;
  } catch (error) {
    selectors.mobile.err.innerText = error;
  }
};
var addressValidation = function (key, value) {
  try {
    if (!value) throw "This field is required";
    if (!/^[a-zA-Z\s]+$/.test(value) && key == "city") throw "Invalid city";
    if (street.length < 3 && key == "street") throw "Invalid street";

    if (user.address.building && user.address.city && user.address.street)
      selectors.address.err.innerText = "";
    user.address[key] = value;
  } catch (error) {
    selectors.address.err.innerText = error;
  }
};

//event handler
var onInputHandler = function (event) {
  var target = event.target;
  switch (target.id) {
    case "name":
      nameValidation(target.value);
      break;
    case "email":
      emailValidation(target.value);
      break;
    case "mobile":
      mobileValidation(target.value);
      break;
    case "city":
      addressValidation(target.id, target.value);
      break;
    case "street":
      addressValidation(target.id, target.value);
      break;
    case "building":
      addressValidation(target.id, target.value);
      break;
  }
  myClareInterval()
};

var onSubmitHandler = function (event) {
  var validUser =
    user.address.building &&
    user.address.city &&
    user.address.street &&
    user.gender &&
    user.email &&
    user.mobile &&
    user.name;
  if (!validUser) {
    event.preventDefault();
    nameValidation(user.name);
    addressValidation("building", user.address.building);
    addressValidation("city", user.address.city);
    addressValidation("street", user.address.street);
    emailValidation(user.email);
    mobileValidation(user.mobile);
  }
  myClareInterval()

};
//events

selectors.name.input.addEventListener("input", onInputHandler);
selectors.email.input.addEventListener("input", onInputHandler);
selectors.mobile.input.addEventListener("input", onInputHandler);
selectors.gender.addEventListener("click", function () {
  user.gender = document.getElementById("m").checked ? "Male" : "Female";
});
selectors.address.city.input.addEventListener("input", onInputHandler);
selectors.address.street.input.addEventListener("input", onInputHandler);
selectors.address.building.input.addEventListener("input", onInputHandler);

selectors.form.addEventListener("submit", onSubmitHandler);

//interval
var counter=30
var interval=setInterval(function(){
  selectors.timeout.innerText="Return To Home After "+counter
  counter=counter-1
  if(counter<=0)
    window.history.back()
},1000)

var myClareInterval=function(){
  if(interval){
    clearInterval(interval)
    selectors.timeout.innerText="Sign Up"
  }
}