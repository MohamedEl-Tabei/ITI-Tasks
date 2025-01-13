// Using ES6 new Syntax & features:
// Write a script to create different shapes (rectangle, square, circle) make
// all of them inherits from shape class.
// a. each shape contains two functions to calculate its area and its
// parameter.
// b. Display the area and each object parameter in your console by
// overriding toString().
// c. Make your classes in an external file and import them in a module
// to create objects.

const rectangle = new Rectangle(5, 4);
const square = new Square(5);
const circle = new Circle(7);
console.log(`Rectangle \n${rectangle.toString()}\n-------------`);
console.log(`Square \n${square.toString()}\n-------------`);
console.log(`Circle \n${circle.toString()}\n-------------`);
