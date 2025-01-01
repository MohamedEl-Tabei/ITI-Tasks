function Rectangle(x, y) {
  if (this.constructor.name === "Rectangle") {
    if (Rectangle.getCout() > 0)
      throw "Only one rectangle is allowed to be created";
    Rectangle.Count++;
  }
  Shape.call(this, x, y);
}
Rectangle.prototype = Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle;
Rectangle.prototype.toString = function () {
  return (
    "width: " +
    this.width +
    "\nheight: " +
    this.height +
    "\narea: " +
    this.area() +
    "\nperimeter: " +
    this.perimeter()
  );
};
Rectangle.Count = 0;
Rectangle.getCout = function () {
  return Rectangle.Count;
};
