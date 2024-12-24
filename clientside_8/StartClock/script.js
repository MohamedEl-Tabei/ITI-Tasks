//selectors
var btn = document.getElementById("btn");
var clock = document.getElementById("clock");

//variables
var interval;

//functions
var getTime = function () {
  return new Date().toTimeString().slice(0, 9);
};

//events
btn.addEventListener("click", function () {
  alert("Clock started");
  btn.style.display = "none";
  interval = setInterval(function () {
    clock.innerHTML = getTime();
  }, 1000);
});

addEventListener("keyup", function (e) {
  if (e.altKey && (e.key == "W" || e.key == "w") && interval) {
    clearInterval(interval);
    clock.innerHTML = "";
    btn.style.display = "block";
    alert("Clock stopped");
  }
});
