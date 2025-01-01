function Squer(x) {
  //Squer.Count it is recommended to not use in conditions because it may be undefined
  if (Squer.getCout() > 0) throw "Only one squer is allowed to be created";
  Squer.Count++;
  Rectangle.call(this, x, x);
}
Squer.prototype = Object.create(Rectangle.prototype);
Squer.prototype.constructor = Squer;
Squer.prototype.toString = function () {
  return (
    "side: " +
    this.height +
    "\narea: " +
    this.area() +
    "\nperimeter: " +
    this.perimeter()
  );
};
Squer.Count = 0;
Squer.getCout = function () {
  return Squer.Count;
};
