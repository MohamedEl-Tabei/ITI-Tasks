//task 1
let x = 5;
let y = 10;
[x, y] = [y, x];
console.log(x, y);

/////////////////////////////////////////
//task 2
/**
 * @description return object with two property max and min
 * @param  {...Number} arg
 * @returns object
 */
let min_max = (...arg) => {
  return { max: Math.max(...arg), min: Math.min(...arg) };
};
console.log(min_max(12, 33, 77, 0, 1));
