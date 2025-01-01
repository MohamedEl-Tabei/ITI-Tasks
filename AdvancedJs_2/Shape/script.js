//var s=new Shape(5,6)

//Rectangle
var rect = new Rectangle(4, 5);
//var rect1 = new Rectangle(4, 5);
document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:red'>" +
  rect.toString() +
  "</h1>";

//Squer
var sqr = new Squer(5);
// var sqr2 = new Squer(5);
document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:green'>" +
  sqr.toString() +
  "</h1>";

//circle
var crl = new Circle(7);
var crl1 = new Circle(7);
var crl2 = new Circle(7);
document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:blue'>" +
  crl.toString() +
  "</h1>";

//get counters
document.body.innerHTML =
  document.body.innerHTML +
  "<h1 style='color:red'>rect number: " +
  Rectangle.getCout() +
  "</h1>" +
  "<h1 style='color:green'>sqr number: " +
  Squer.getCout() +
  "</h1>" +
  "<h1 style='color:blue'>crcl number: " +
  Circle.getCout() +
  "</h1>";
