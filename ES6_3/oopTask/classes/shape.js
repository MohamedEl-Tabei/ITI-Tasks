class Shape {
  constructor(w, h) {
    if (this.constructor.name == "Shape") throw "Shape is abstract class";
    this.width = w;
    this.height = h;
  }
  /**
   *
   * @returns Number
   */
  getArea = () => this.width * this.height;
  /**
   *
   * @returns Number
   */
  getParameter = () => (this.height + this.width) * 2;
  /**
   *
   * @returns Display Area & Parameter
   */
  toString = () => `Area=${this.getArea()}\nParameter=${this.getParameter()}`;
}

export default Shape;
