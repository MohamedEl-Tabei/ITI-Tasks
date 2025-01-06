$("#s1").click(function () {
  if ($("#c1").css("display") == "none") $("#c1").slideDown();
  else $("#c1").slideUp();
});

$("#s2").click(function () {
  if ($("#c2").css("display") == "none") $("#c2").slideDown();
  else $("#c2").slideUp();
});

$(".sideBar").mouseover(function () {
  $(".sideBar")
    .stop()
    .animate({ width: "10%" }, 1000, function () {
      $("ul").show();
    });
});

$(".sideBar").mouseout(function () {
  $(".sideBar")
    .stop()
    .animate({ width: "1%" }, 1000, function () {
      $("ul").hide();
    });
});
