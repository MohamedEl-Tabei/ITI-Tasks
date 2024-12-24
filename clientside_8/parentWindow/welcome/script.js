setTimeout(function () {
  close();
}, 5000);

var str = "Welcome";
for (var i = 0; i < str.length; i++) {
  (function () {
    var index = i;
    setTimeout(function () {
      document.getElementById("welcome").innerText = str.slice(0, index + 1);
    }, i * 500);
  })();
}
