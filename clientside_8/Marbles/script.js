//variables
var count = 1;
var interval;
//selectors
var container = document.getElementsByClassName("container-images")[0];

interval = setInterval(function () {
  document.getElementById("img" + count).setAttribute("src", "imgs/1.webp");
  count = count < 4 ? count + 1 : 1;
  document.getElementById("img" + count).setAttribute("src", "imgs/2.webp");
}, 1000);

container.addEventListener("mouseover", function () {
  document.getElementById("img" + count).setAttribute("src", "imgs/1.webp");
  clearInterval(interval);
  count=1
});

container.addEventListener("mouseout", function () {
  interval = setInterval(function () {
    document.getElementById("img" + count).setAttribute("src", "imgs/1.webp");
    count = count < 4 ? count + 1 : 1;
    document.getElementById("img" + count).setAttribute("src", "imgs/2.webp");
  }, 1000);
});
