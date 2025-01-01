/**
 *Function Constraint
 * @param {Number} _height
 * @param {Number} _width
 * @param {Number} _length
 * @param {Number} _numOfBooks
 * @param {String} _material
 * @param {String} _type
 * @param {Array} _content
 */
function Box(
  _height,
  _width,
  _length,
  _maxNumOfBooks,
  _material,
  _type,
  _content
) {
  var height = _height || 0;
  var width = _width || 0;
  var length = _length || 0;
  var material = _material || "";
  var type = _type || "";
  var content = _content || [];
  var maxNumOfBooks = _maxNumOfBooks || 3;
  //setter
  this.setHeight = function (val) {
    height = val;
  };
  this.setWidth = function (val) {
    width = val;
  };
  this.setLength = function (val) {
    length = val;
  };
  this.setMaterial = function (val) {
    material = val;
  };
  this.setType = function (val) {
    type = val;
  };
  this.setMaxNumOfBox = function (val) {
    maxNumOfBooks = val;
  };
  //getter
  this.getHeight = function () {
    return height;
  };
  this.getWidth = function () {
    return width;
  };
  this.getLength = function () {
    return length;
  };
  this.getMaterial = function () {
    return material;
  };
  this.getType = function () {
    return type;
  };
  this.getContent = function () {
    //return reference content
    //return content;
    return Array.from(content);
  };
  this.getMaxNumOfBooks = function () {
    return maxNumOfBooks;
  };
  this.getNumOfBooks = function () {
    return content.length;
  };
  this.getVolume = function () {
    return height * width * length;
  };
  //methods
  this.addBook = function (newBook) {
    if (content.length < maxNumOfBooks) content.push(newBook);
    else throw "Box is full";
  };
  this.deleteBook = function (typeOrName) {
    var arr = [];
    var book;
    while (content.length) {
      book = content.pop();
      if (book.getType() != typeOrName && book.getName() != typeOrName)
        arr.push(book);
    }
    content=arr
  };
}

Box.prototype.toString = function () {
  return (
    "Width: " +
    this.getWidth() +
    "<br>Height: " +
    this.getHeight() +
    "<br>Length: " +
    this.getLength() +
    "<br>Volume: " +
    this.getVolume() +
    "<br>Material: " +
    this.getMaterial() +
    "<br>Max number of books: " +
    this.getMaxNumOfBooks() +
    "<br>Number of books: " +
    this.getNumOfBooks() +
    "<br>Type: " +
    this.getType() +
    "<br>Content: " +
    this.getContent()
  );
};
Box.prototype.valueOf=function(){
  return this.getNumOfBooks()
}