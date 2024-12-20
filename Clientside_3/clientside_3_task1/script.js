
// - Task1
    
//     Write a script that takes from the user n values and returns their sum, stop receiving
//     values from user when he enters 0 or sum exceeds 100, check that the entered data is
//     numeric and inform the user with the total sum of the entered values. (use do while
//     loop)

var sum = 0;
var num;

do {
  num = prompt("Please Enter Number");
  sum = isFinite(num) ? sum + Number(num) : sum;
} while ((num != 0 && sum < 100) || isNaN(num));

document.write("<h1>sum = " + sum + "</h1>");
