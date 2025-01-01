/**
 *Function Constraint
 * @param {String} _name
 * @param {String} _type
 * @param {Number} _numofChapters
 * @param {String} _author
 * @param {Number} _numPages
 * @param {String} _publisher
 * @param {Number} _numofCopies
 */
function Book(
  _name,
  _type,
  _numofChapters,
  _author,
  _numPages,
  _publisher,
  _numofCopies
) {
  var name = _name || "";
  var type = _type || "";
  var numofChapters = _numofChapters || 0;
  var author = _author || "";
  var numPages = _numPages || 0;
  var publisher = _publisher || "";
  var numofCopies = _numofCopies || 0;
  //setters
  this.setName = function (val) {
    name = val;
  };
  this.setType = function (val) {
    type = val;
  };
  this.setNumOfChapters = function (val) {
    numofChapters = val;
  };
  this.setAuther = function (val) {
    author = val;
  };
  this.setNumPages = function (val) {
    numPages = val;
  };
  this.setPublisher = function (val) {
    publisher = val;
  };
  this.setNumOfCopies = function (val) {
    numofCopies = val;
  };
  //getter
  this.getName = function () {
    return name;
  };
  this.getType = function () {
    return type;
  };
  this.getNumOfChapters = function () {
    return numofChapters;
  };
  this.getAuther = function () {
    return author;
  };
  this.getNumPages = function () {
    return numPages;
  };
  this.getPublisher = function () {
    return publisher;
  };
  this.getNumOfCopies = function () {
    return numofCopies;
  };
}
Book.prototype.toString = function () {
  return (
    "<h2><br>______________________<br>" +
    "Auther: " +
    this.getAuther() +
    "<br>Name: " +
    this.getName() +
    "<br>Number of chapters: " +
    this.getNumOfChapters() +
    "<br>Number of copies: " +
    this.getNumOfCopies() +
    "<br>Number of pages: " +
    this.getNumPages() +
    "<br>Publisher: " +
    this.getPublisher() +
    "<br>Type: " +
    this.getType() +
    "</h2>"
  );
};
