function* fibonacci1(count) {
  let a = 0;
  let b = 1;
  let temp;
  yield a;
  for (let i = 1; i < count; i++) {
    yield b;
    temp = b;
    b = a + b;
    a = temp;
  }
}
let fb1 = fibonacci1(4);
console.log(
  "1. the parameter passed determines the number of elements displayed from the series. "
);
console.log(fb1.next());
console.log(fb1.next());
console.log(fb1.next());
console.log(fb1.next());
console.log(fb1.next());
