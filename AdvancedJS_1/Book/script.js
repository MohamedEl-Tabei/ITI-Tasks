//function constructor
function Book(name, price, autherName, autherEmail) {
  this.name = name;
  this.price = price;
  this.author = new Author(autherName, autherEmail);
}
function Author(name, email) {
  this.name = name;
  this.email = email;
}

//Selectors
var selectors = {
  getNumberOfBooks: document.getElementById("getNumberOfBooks"),
  addBook: document.getElementById("addBook"),
  number: document.getElementById("number"),
  title: document.getElementById("title"),
  price: document.getElementById("price"),
  "author name": document.getElementById("autherName"),
  authorEmail: document.getElementById("autherEmail"),
  tbody: document.querySelector("tbody"),
};

//mounted
selectors.getNumberOfBooks.style.display = "flex";
//variables
var obj = {
  books: [],
  number: 0,
};

//handlers
var validation = {
  text: function (label) {
    var t = selectors[label].value;
    if (!t) functions.setErrorMessage(label + " is required", selectors[label]);
    else if (!/^[a-zA-Z]+$/.test(t))
      functions.setErrorMessage(
        label + " must contain only alphabetical",
        selectors[label]
      );
    else return true;
    return false;
  },
  price: function () {
    var p = selectors.price.value;
    if (!p) functions.setErrorMessage("price is required", selectors.price);
    else if (p > 100)
      functions.setErrorMessage("max price is 100", selectors.price);
    else if (p < 10)
      functions.setErrorMessage("min price is 10", selectors.price);
    else return true;
    return false;
  },
  email: function () {
    if (!selectors.authorEmail.value)
      functions.setErrorMessage("email is required", selectors.authorEmail);
    else if (
      !/^[a-zA-Z][a-zA-Z0-9_]+@[a-zA-Z]+\.[a-zA-Z]{3,}$/.test(
        selectors.authorEmail.value
      )
    )
      functions.setErrorMessage("invalid email", selectors.authorEmail);
    else return true;
    return false;
  },
};
var functions = {
  setErrorMessage: function (message, input) {
    input.parentElement.lastChild.remove();
    var small = document.createElement("small");
    small.innerText = message;
    input.after(small);
  },
  getNumberOfBooks: function () {
    var value = Number(selectors.number.value);
    if (value) {
      obj.number = value;
      selectors.getNumberOfBooks.style.display = "none";
      selectors.addBook.style.display = "flex";
    } else
      this.setErrorMessage("number of books is required", selectors.number);
  },
  addBook: function () {
    var valid = true;
    if (!validation.price()) valid = false;
    if (!validation.text("title")) valid = false;
    if (!validation.text("author name")) valid = false;
    if (!validation.email()) valid = false;

    if (valid) {
      obj.books.push(
        new Book(
          selectors.title.value,
          selectors.price.value,
          selectors["author name"].value,
          selectors.authorEmail.value
        )
      );
      selectors.title.value = "";
      selectors.price.value = "";
      selectors["author name"].value = "";
      selectors.authorEmail.value = "";
    }
    if (obj.books.length == obj.number) {
      selectors.addBook.style.display = "none";
      obj.books.forEach(function (book) {
        var tr = document.createElement("tr");
        tr.innerHTML =
          "<td>" +
          book.name +
          "</td>" +
          "<td>" +
          book.price +
          "</td>" +
          "<td>" +
          book.author.name +
          "</td>" +
          "<td>" +
          book.author.email +
          "</td>" +
          "<td><button>Edit</button><button class='delete'>Delete</button></td>";
        selectors.tbody.append(tr);
        selectors.tbody.parentElement.style.visibility = "visible";
      });
    }
  },
};

var onSubmitHandler = function (event) {
  event.preventDefault();
  var id = this.id;
  functions[id]();
};
var onChangeHandlr=function(){
  functions.setErrorMessage("",this)
}
//events
selectors.getNumberOfBooks.addEventListener("submit", onSubmitHandler);
selectors.addBook.addEventListener("submit", onSubmitHandler);
selectors.title.addEventListener("input", onChangeHandlr);
selectors.number.addEventListener("input", onChangeHandlr);
selectors["author name"].addEventListener("input", onChangeHandlr);
selectors.authorEmail.addEventListener("input", onChangeHandlr);
selectors.price.addEventListener("input", onChangeHandlr);
