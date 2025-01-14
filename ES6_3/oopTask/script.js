import Circle from "./classes/circle.js";
import Rectangle from "./classes/rectangle.js";
import Square from "./classes/square.js";

const rectangle = new Rectangle(5, 4);
const square = new Square(5);
const circle = new Circle(7);
console.log(`Rectangle \n${rectangle.toString()}\n-------------`);
console.log(`Square \n${square.toString()}\n-------------`);
console.log(`Circle \n${circle.toString()}\n-------------`);
