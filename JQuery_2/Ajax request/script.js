$.get("https://jsonplaceholder.typicode.com/users", function (users) {
  users.forEach(function (user, i) {
    $("<li class='" + (i == 0 ? "active" : "") + "'>" + user.name + "</li>")
      .appendTo("ul")
      .click(function () {
        $(this).addClass("active").siblings().removeClass("active");
        getUserPosts(user.id);
      });
    if (i == 0) {
      getUserPosts(user.id);
    }
  });
}).fail(handleError);

function getUserPosts(userId) {
  $(".loader-container").show();
  $(".container").html("");
  $.get(
    "https://jsonplaceholder.typicode.com/posts?userId=" + userId,
    displayPosts
  ).fail(handleError);
}

function displayPosts(posts) {
  posts.forEach(function (post, i) {
    $("<div class='card'>" + post.title + "</div>")
      .appendTo(".container")
      .animate({ opacity: 1, "transition-duration": i + "s" });
  });
  $(".loader-container").hide();
}

function handleError() {
  $("body").html("<h1 class='error'>Something Wrong</h1>");
  $(".loader-container").hide();
}
