$(".container")
  .animate({ width: "100%" }, 5000)
  .animate({ height: "100%" }, 5000);

for (var i = 0; i < 4; i++) {
  // append images
  $(
    "<div class='image hidden'><img id='" +
      (i + 1) +
      "' src='images/" +
      (i + 1) +
      ".webp'" +
      "'/></div>"
  ).appendTo(".container-image");
}

$(".hidden").each(function (i, e) {
  $(e)
    .delay(i + 10000)
    .animate({ opacity: 1 });
});
