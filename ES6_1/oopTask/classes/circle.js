class Circle extends Shape {
  constructor(r) {
    super(r, r);
  }
  /**
   *
   * @returns Number
   */
  getArea = () => Math.pow(this.height, 2) * Math.PI;
  /**
   *
   * @returns Number
   */
  getParameter = () => this.height * Math.PI * 2;
}
