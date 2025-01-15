function* fibonacci2(max) {
  let a = 0;
  let b = 1;
  let temp;
  yield a;
  while (b < max) {
    yield b;
    temp = b;
    b = a + b;
    a = temp;
  }
}
let fb2 = fibonacci2(4);
console.log(
  "2. the parameter passed determines the max number of the displayed series should not exceed its value."
);

console.log(fb2.next());
console.log(fb2.next());
console.log(fb2.next());
console.log(fb2.next());
console.log(fb2.next());
console.log(fb2.next());
console.log(fb2.next());
