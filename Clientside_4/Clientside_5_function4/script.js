// 4.4 make function isPrime to check if the number is prime or not

/**
 * take one param and check if it is a prime
 * @param {Number} x 
 * @returns Boolean
 */

function isPrime(x) {
  if (arguments.length != 1||typeof x!="number") throw "isPrime Take Only One Parameter of Number";
  var end = x > 9 ? 10 : x;
  for (var i = 2; i < end; i++) {
    if (x % i == 0) return false;
  }
  return x == 1 ? false : true;
}
console.log(1,isPrime(1));
console.log(2,isPrime(2));
console.log(3,isPrime(3));
console.log(4,isPrime(4));
console.log(5,isPrime(5));
console.log(6,isPrime(6));
console.log(7,isPrime(7));
console.log(8,isPrime(8));
console.log(9,isPrime(9));
console.log(10,isPrime(10));
