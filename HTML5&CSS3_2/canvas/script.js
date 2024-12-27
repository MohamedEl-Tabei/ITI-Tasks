var selectors = {
  canvas: document.querySelector("canvas"),
  color: document.querySelector("input"),
  clickMe: document.querySelector("button"),
};

var ctx = selectors.canvas.getContext("2d");
ctx.strokeStyle = "black";

function generate() {
  for (var i = 0; i < 100; i++) {
    var x = Math.random() * 500;
    var y = Math.random() * 500;
    ctx.beginPath();
    ctx.arc(x, y, 18, 0, 2 * Math.PI, true);
    ctx.stroke();
  }
}
generate();

selectors.clickMe.addEventListener("click", function () {
  ctx.clearRect(0, 0, 500, 500);
  ctx.strokeStyle = selectors.color.value;
  generate();
});
