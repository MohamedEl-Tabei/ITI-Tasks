var selectors = {
  rememberMe: document.getElementById("remeberMe"),
  form: document.querySelector("form"),
  name: document.getElementById("name"),
  email: document.getElementById("email"),
};

if (localStorage.name) selectors.name.value = localStorage.name;

if (localStorage.email) selectors.email.value = localStorage.email;

selectors.form.addEventListener("submit", function () {
  if (selectors.rememberMe.checked) {
    localStorage.name = selectors.name.value;
    localStorage.email = selectors.email.value;
  } else {
    localStorage.clear();
  }
});
