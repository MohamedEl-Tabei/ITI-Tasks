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
    var oldData = {};
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
          "<td><button class='edit'>Edit</button><button class='delete'>Delete</button></td>";
        selectors.tbody.append(tr);
        selectors.tbody.parentElement.style.visibility = "visible";
        tr.addEventListener("input", function (event) {
          var id = event.target.id;
          var value = event.target.value;
          if (id == "title") book.name = value;
          if (id == "price") book.price = value;
          if (id == "autherName") book.author.name = value;
          if (id == "autherEmail") book.author.email = value;
        });
        tr.addEventListener("click", function (event) {
          if (event.target.className == "delete") {
            functions.deleteBook(book.name);
            this.remove();
          }
          if (event.target.className == "edit") {
            oldData = [];
            for (var key in book) {
              console.log(key);

              if (key == "author")
                oldData.author = { name: book.author.name, email: book.author.email };
              else oldData[key] = book[key];
            }
            tr.innerHTML =
              "<td>" +
              "<input type='text' id='title' value=" +
              book.name +
              " />" +
              "</td>" +
              "<td>" +
              "<input type='number' id='price' value=" +
              book.price +
              " />" +
              "</td>" +
              "<td>" +
              "<input type='text' id='autherName' value=" +
              book.author.name +
              " />" +
              "</td>" +
              "<td>" +
              "<input type='email' id='autherEmail' value=" +
              book.author.email +
              " />" +
              "</td>" +
              "<td><button class='save'>Save</button><button class='cancle'>Cancle</button></td>";
          }
          if (event.target.className == "save") {
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
              "<td><button class='edit'>Edit</button><button class='delete'>Delete</button></td>";
          }
          if (event.target.className == "cancle") {
            tr.innerHTML = "";
            for(var key in oldData){
              book[key]=oldData[key]
              if (key == "author")
                tr.innerHTML = tr.innerHTML + "<td>" + oldData[key].name + "</td>"+"<td>" + oldData[key].email + "</td>";
              else
              tr.innerHTML = tr.innerHTML + "<td>" + oldData[key] + "</td>";
            };

            tr.innerHTML =
              tr.innerHTML +
              "<td><button class='edit'>Edit</button><button class='delete'>Delete</button></td>";
          }
        });
      });
    }
  },
  deleteBook: function (bName) {
    var arr = [];
    var topBook;
    while (obj.books.length) {
      topBook = obj.books.pop();
      if (bName != topBook.name) arr.push(topBook);
    }
    obj.books = arr;
  },
};

var onSubmitHandler = function (event) {
  event.preventDefault();
  var id = this.id;
  functions[id]();
};
var onChangeHandlr = function () {
  functions.setErrorMessage("", this);
};
//events
selectors.getNumberOfBooks.addEventListener("submit", onSubmitHandler);
selectors.addBook.addEventListener("submit", onSubmitHandler);
selectors.title.addEventListener("input", onChangeHandlr);
selectors.number.addEventListener("input", onChangeHandlr);
selectors["author name"].addEventListener("input", onChangeHandlr);
selectors.authorEmail.addEventListener("input", onChangeHandlr);
selectors.price.addEventListener("input", onChangeHandlr);
