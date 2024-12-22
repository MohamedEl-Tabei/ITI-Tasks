var password = "";

//selectors
var iPassword = document.getElementById("password");
var iPassword2 = document.getElementById("password2");
var eye = document.getElementById("eye");

iPassword.addEventListener("input", function () {
  password = this.value;
  iPassword2.value =""
  for (var i = 0; i < password.length; i++) {
    iPassword2.value = iPassword2.value + "●";
  }
});

eye.addEventListener("click", function () {
  var src = this.getAttribute("src");
  if (src == "svgs/eye-slash-solid.svg") {
    this.setAttribute("src", "svgs/eye-solid.svg");
    iPassword2.style.opacity=0;
    iPassword.style.opacity=1;
  } else {
    this.setAttribute("src", "svgs/eye-slash-solid.svg");
    iPassword.style.opacity=0;
    iPassword2.style.opacity=1;

  }
});
