let fruits = ["apple", "strawberry", "banana", "orange", "mango"];
// a. test that every element in the given array is a string
let isAllString = fruits.every((fruit) => typeof fruit == "string");
console.log(`isAllString: ${isAllString}`);

// b. test that some of array elements starts with "a"
let someStartWith_a = fruits.some((fruit) => fruit[0] == "a");
console.log(`someStartWith_a: ${someStartWith_a}`);

// c. generate new array filtered from the given array with only elements that starts with "b" or "s"
let startWith_b_s = fruits.filter(
  (fruit) => fruit[0] == "b" || fruit[0] == "s"
);
console.log(`startWith_b_s: ${startWith_b_s}`);

// d. generate new array each element of the new array contains a string declaring that you like the give fruit element
// “I like ” + fruit[0]
let iLikeArray=fruits.map((fruit)=>`I like ${fruit}`)


// e. use `forEach` to display all elements of the new array from previous point.
iLikeArray.forEach(fruit=>{
    console.log(fruit)
})