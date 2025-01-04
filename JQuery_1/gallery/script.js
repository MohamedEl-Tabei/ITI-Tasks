var index = 0;
for (var i = 0; i < 4; i++) {
  // append images
  $(
    "<div class='image'><img id='" +
      (i + 1) +
      "' src='images/" +
      (i + 1) +
      ".webp'" +
      "'/></div>"
  ).appendTo("body");
}
$(".modal").hide();

//open modal
$("body").on("click", ".image", function () {
  $(".modal").show();
  $(".modal img").attr("src", this.children[0].src);
  index = Number($(this.children[0]).attr("id"));
});

//hide modal
var hidModal = function () {
  $(this).hide();
};

$(".modal").on("click", hidModal);

//Click on children
$(".in-btn").click(function () {
  $(".modal").off();
  index = index < 4 ? index + 1 : index;
  $(".modal img").attr("src", "images/" + index + ".webp");
});
$(".de-btn").click(function () {
  $(".modal").off();
  index = index > 1 ? index - 1 : index;
  $(".modal img").attr("src", "images/" + index + ".webp");
});
$(".modal img").click(function () {
  $(".modal").off();
});

//mouseout children
$(".modal")
  .children()
  .each(function () {
    $(this).mouseout(function () {
      $(".modal").on("click", hidModal);
    });
  });
