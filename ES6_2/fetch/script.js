fetch("https://jsonplaceholder.typicode.com/users")
  .then((response) => {
    return response.json();
  })
  .then((users) => {
    users.forEach(async function (user, i) {
      let li = document.createElement("li");
      li.className = i == 0 ? "active" : "";
      li.innerText = user.name;
      li.addEventListener("click", async function () {
        unActivLi();
        this.className = "active";
        await getUserPosts(user.id);
      });
      document.getElementsByTagName("ul")[0].append(li);
      if (i == 0) {
        await getUserPosts(user.id);
      }
    });
  })
  .catch(() => handleError("error when get users"));

/**
 * @description async function to fetch user posts by user id
 * @param {Number} userId
 */
async function getUserPosts(userId) {
  loaderShow();
  document.getElementsByClassName("container")[0].innerHTML = "";
  try {
    let posts = await fetch(
      `https://jsonplaceholder.typicode.com/posts?userId=${userId}`
    );
    displayPosts(await posts.json());
  } catch (err) {
    handleError("Error when get user's posts by id");
  }
}

/**
 * @description function to display user posts
 * @param {Object} posts
 */
function displayPosts(posts) {
  posts.forEach(function (post, i) {
    let card = document.createElement("div");
    card.className = "card";
    card.innerText = post.title;
    document.getElementsByClassName("container")[0].append(card);
  });
  loaderHide();
}

/**
 * @description function to disply error to user
 */
function handleError(err) {
  document.body.innerHTML = `<h1 class='error'>${err}</h1>`;
  loaderHide();
}

function loaderShow() {
  document.getElementsByClassName("loader-container")[0].style.display = "flex";
}
function loaderHide() {
  document.getElementsByClassName("loader-container")[0].style.display = "none";
}
/**
 * @description to make all name of user unactivated
 */
function unActivLi() {
  const elements = Array.from(document.getElementsByTagName("li"));
  elements.forEach((element) => {
    element.className = "";
  });
}
