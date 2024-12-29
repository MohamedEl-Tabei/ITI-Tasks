// Using Constructor method for creating Objects, write a script that allows
// you to create a rectangle object that :
// • Should have width and height properties.
// • Implement two methods for calculating its area and perimeter.
// • Implement displayInfo() function to display a message declaring the
// width, height, area and perimeter of the created object.
function Rectangle (width, height) {
  this.width = width;
  this.height = height;
};

Rectangle.prototype.area = function () {
  return this.width * this.height;
};
Rectangle.prototype.perimeter =function(){
  return (this.width+this.height)*2
}
Rectangle.prototype.displayInfo=function(){
    document.body.innerHTML=`
                                <div>
                                    <h1>Height: ${this.height}</h1>
                                    <h1>Width: ${this.width}</h1>
                                    <h1>Area: ${this.area()}</h1>
                                    <h1>Perimeter: ${this.perimeter()}</h1>
                                </div>
    `
}
////////////////////////////////////////////
var rectangle = new Rectangle(5, 6);
rectangle.displayInfo()
console.log(rectangle.area());

