var body = document.body;
var cookies = {
  setCookie: function (key, value, expireDate) {
    document.cookie = key + "=" + value + ";expires=" + expireDate;
  },
  hasCookie: function (key) {
    return document.cookie.includes(key);
  },
  allCookieList: function () {
    var cookiesList = [];
    document.cookie.split("; ").forEach(function (k_v) {
      var arrKV = k_v.split("=");
      cookiesList.push(arrKV);
    });
    return cookiesList;
  },
  getCookie: function (key) {
    var value;
    cookies.allCookieList().forEach(function (arrKV) {
      value = key == arrKV[0] ? arrKV[1] : value;
    });
    return value;
  },
  deleteCookie: function (key) {
    var date = new Date();
    date.setDate(date.getDate() - 20);
    cookies.setCookie(key, "data", date);
  },
  hasCookies: function () {
    return (
      this.hasCookie("name") &&
      this.hasCookie("age") &&
      this.hasCookie("color") &&
      this.hasCookie("gender")
    );
  },
};

//data of input
function getData() {
  return {
    name: $("#name").val(),
    age: $("#age").val(),
    color: $("#color").val(),
    gender: $("#m")[0]?.checked ? "m" : "f",
    counter: 0,
  };
}

//when user registered
if (body.id == "register" && cookies.hasCookies())
  location.href = "profile.html";

//when user in his profile
if (body.id == "profile") {
  var userName = cookies.getCookie("name");
  var gender = cookies.getCookie("gender");

  //increment counter
  var data = getData();
  var date = new Date();
  date.setDate(date.getDate() + 10);
  cookies.setCookie("counter", Number(cookies.getCookie("counter")) + 1, date);

  //handle profile
  $("#profileImg").attr("src", "images/" + gender + ".png");
  $("h1")
    .text(
      "Welcome " +
        userName +
        ", you have visited this page " +
        cookies.getCookie("counter") +
        " times"
    )
    .css("color", cookies.getCookie("color"));
  //user not registered
  if (!cookies.hasCookies()) location.href = "index.html";
}

//register form
$(".form1").submit(function (event) {
  var data = getData();
  var date = new Date();
  date.setDate(date.getDate() + 10);
  event.preventDefault();
  for (var key in data) {
    cookies.setCookie(key, data[key], date);
  }
  location.href = "profile.html";
});

//logout
$(".form2").submit(function (event) {
  var data = getData();
  event.preventDefault();
  for (var key in data) {
    cookies.deleteCookie(key);
  }
  location.href = "index.html";
});
