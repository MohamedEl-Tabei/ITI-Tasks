// - String object

//     1.1 Write a script to determine whether the entered string is palindrome or not. Ask the
//     user whether to consider case of the entered string or not, handle both cases in your
//     script i.e. RADAR NOON MOOM are palindrome.
//     Note: raDaR is not a palindrome if user requested considering case of entered string.

/**
 * function to determine whether the entered string is palindrome or not.
 * @param {string} str
 * @returns {Boolean}
 */

function isPalindrome(str) {
  var useCaseSensetive = false;
  var strRev = str.split("").reverse().toString().replaceAll(",", "");
  useCaseSensetive = confirm("consider case of the entered string or not");
  if (useCaseSensetive) {
    return str === strRev;
  } else {
    return str.toLowerCase() === strRev.toLowerCase();
  }
}

var s;

do {
  s = prompt("Enter a string to check palindrome or not.");
} while (!s);
var message = isPalindrome(s) ? " " : "not ";
document.write("<h1>" + s + " is " + message + "palindrome.</h1>");

//     1.2 write a script that accepts a string from user through prompt and count the number of
//     ‘e’ characters in it.

/**
 * function that accepts a string from user through prompt and count the number of ‘e’ characters in it.
 */
function countE() {
  var str;
  do {
    str = prompt("Enter a string to count e");
  } while (!str);
  var count = 0;
  for (var i = 0; i < str.length; i++)
    count = str[i].toLocaleLowerCase() == "e" ? count + 1 : count;
  document.write("<h1>Number of e in " + str + " is " + count + "</h1>");
}

function countE2() {
  var str;
  var reg=new RegExp("e","g")
  do {
    str = prompt("Enter a string to count e");
  } while (!str);
  
  document.write("<h1>Number of e in " + str + " is " + str.match(reg).length + "</h1>");
}
 //countE2();





//     1.3 Write a script that reads from the user his info; validates and displays it with a
//     welcoming message.

/**
 * function that reads from the user his info; validates and displays it with a welcoming message.
 */
function takeInfo() {
  var name;
  var phone;
  var mobile;
  var email;

  do {
    name = prompt("Please enter your name");
  } while (!/^[a-zA-Z]+$/.test(name));

  do {
    phone = prompt("Please enter your phone");
  } while (!/^[0-9]+$/.test(phone) || phone.length != 8);
  do {
    mobile = prompt("Please enter your mobile");
  } while (!/^(010|011|12|015)[0-9]+$/.test(mobile) || mobile.length != 11);
  do {
    email = prompt("Please enter your email");
  } while (!/^[0-9a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]{2,}$/.test(email));

  document.write("<h1 style='color:red;text-align:center'>Welcome "+name+"</h1>")
  document.write("<h1><span style='color:red;margin-right:5px'>Phone</span>"+phone+"</h1>")
  document.write("<h1><span style='color:red;margin-right:5px'>Mobile</span>"+mobile+"</h1>")
  document.write("<h1><span style='color:red;margin-right:5px'>Email</span>"+email+"</h1>")
}
// takeInfo()