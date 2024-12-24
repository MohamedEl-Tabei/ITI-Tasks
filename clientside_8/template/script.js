var user = {
  name: "",
  email: "",
  mobile: "",
  gender: "Male",
  city: "",
  street: "",
  building: "",
};
if (window.location.search) {
  //selectors
  var welcomeMessage = document.getElementById("welcome");
  var navbarBtn = document.getElementById("navBtn");
  var data = window.location.search
    .replaceAll("%40", "@")
    .replaceAll("+", " ")
    .slice(1)
    .split("&");
  for (var i = 0; i < data.length; i++) {
    var arr = data[i].split("=");
    user[arr[0]] = arr[1];
  }
  welcomeMessage.style.marginLeft=0
  welcomeMessage.innerText = "Welcome " + user.name.split(" ")[0];
  navbarBtn.innerHTML = "<button>" + user.email + "</button>";
  navbarBtn.setAttribute("href","#home")
}
