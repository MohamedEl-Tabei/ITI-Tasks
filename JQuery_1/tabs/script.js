var tabs = ["Tab one", "Tab two", "Tab three", "Tab four"];
var contents = ["tab 1", "tab 2", "tab 3", "tab 4"];
var active = 0;


$(".content").text(contents[0])

tabs.forEach(function (tab, i) {
  $("<li id='" + i + "'>" + tab + "</li>").appendTo(".card ul");
  if (i == active) $("#" + i).attr("class", "active");
  $("#" + i).click(function(){
    $(this).toggleClass("active")
    $(this).siblings().toggleClass("active",false);
    $(".content").text(contents[i])
  })
});

