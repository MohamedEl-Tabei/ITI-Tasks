var box = new Box(1, 2, 3, 10, "Plastic", "box1", []);

box.addBook(new Book("book1", "type1", 10, "ali", 100, "publisher1", 5));
box.addBook(new Book("book2", "type2", 10, "ahmed", 100, "publisher1", 5));
box.addBook(new Book("book3", "type3", 10, "mohamed", 100, "publisher1", 5));
box.addBook(new Book("book4", "type1", 10, "ziad", 100, "publisher1", 5));
box.addBook(new Book("book5", "type1", 10, "ali", 100, "publisher1", 5));

document.body.innerHTML = "<h1>" + box.toString() + "</h1>";

box.deleteBook("type1");
document.body.innerHTML =
  document.body.innerHTML + "<h1 style='color:red'>" + box.toString() + "</h1>";

box.deleteBook("book2");
document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:green'>" +
  box.toString() +
  "</h1>";

var box_ = new Box(1, 2, 3, 10, "Plastic", "box1", []);
box_.addBook(new Book("book1", "type1", 10, "ali", 100, "publisher1", 5));
box_.addBook(new Book("book2", "type2", 10, "ahmed", 100, "publisher1", 5));

document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:blue'> box+box_= " +
  (box + box_) +
  "</h1>";
