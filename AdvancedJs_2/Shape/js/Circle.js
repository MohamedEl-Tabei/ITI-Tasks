function Circle(r) {
  Circle.Count++;
  Shape.call(this, r, r);
}
Circle.prototype = Object.create(Shape.prototype);
Circle.prototype.constructor = Circle;
Circle.prototype.area = function () {
  return this.height * this.width * Math.PI;
};
Circle.prototype.perimeter = function () {
  return 2 * Math.PI * this.height;
};
Circle.prototype.toString = function () {
  return (
    "r: " +
    this.height +
    "\narea: " +
    this.area() +
    "\nperimeter: " +
    this.perimeter()
  );
};
Circle.Count = 0;
Circle.getCout = function () {
  return Circle.Count;
};
