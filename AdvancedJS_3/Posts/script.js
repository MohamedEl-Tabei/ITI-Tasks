var html = {
  error: "<h1>Error 404 Not Found</h1>",
  loader: "<div class='loader'></div>",
  empty:"<h1>No Posts Avilible </h1>"
};
document.body.innerHTML = html.loader;

var xhr = new XMLHttpRequest();
xhr.open("get", "https://jsonplaceholder.typicode.com/posts");
xhr.send();
xhr.addEventListener("error", function () {
  document.body.innerHTML = html.error;
});
xhr.addEventListener("readystatechange", function (event) {
  if (event.target.readyState === 4 ) {
    var posts = JSON.parse(event.target.response);
    document.body.innerHTML = "";
    // posts=[]
    if(posts.length)
    {
        posts.forEach(function (post) {
            displayPost(post);
        });
    }
    else{
        document.body.innerHTML = html.empty;
    }
  }
});
var displayPost = function (post) {
  var div = document.createElement("div");
  div.className="card"
  div.innerHTML = "<h3>" + post.title + "</h3>" + "<p>" + post.body + "</p>";
  document.body.append(div);
};
