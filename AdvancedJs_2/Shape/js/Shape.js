//abstract class
function Shape(w, h) {
  if (this.constructor.name == "Shape")
    throw "abstract class can't have instance";
  this.height = h;
  this.width = w;
}
Shape.prototype.area = function () {
  return this.height * this.width;
};
Shape.prototype.perimeter = function () {
  return 2 * (this.height + this.width);
};
