// 1.1. Show prompt that ask user to enter his birth date and tell user to enter the
// date in the following format (DD – MM – YYYY) ex. 22–01–1999, and then create
// function that take user input as a parameter and ensure that the string is entered
// in this format (that user entered string is 10 characters and contains (-) after the
// second character and after fifth character).[Don't use RegExp, use string
// functions].

// a. If the user input was correct: make the function create new date object, and
// initialize it with Day, Month, year values (using date constructor: Date(y,m,d)) and
// then show alert to the user with the date in date string format. “16 December 2024”
// b. If user input wasn't correct, show alert saying, "Wong Date Format".

var date = "";
/**
 * date validation
 * @param {string} myDate
 * @returns
 */
function dateValidation(myDate) {
  return (
    myDate.length === 10 && myDate.charAt(2) === "-" && myDate.charAt(5) === "-"
  );
}
function monthOfBirth(monthNumber) {
  var arrOfMonth = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December",
  ];
  return arrOfMonth[monthNumber];
}
do {
  date = prompt("Enter your birth date (DD – MM – YYYY)");
} while (!dateValidation(date));
var arrDate = date.split("-");

var birthDay = new Date(arrDate[2], arrDate[1] - 1, arrDate[0]);
if (
  birthDay.getFullYear() != arrDate[2] ||
  birthDay.getMonth() != arrDate[1] - 1
)
  alert("Wong Date Format");
else {
  document.write("<h1>" + dayOfBirth(birthDay) + "</h1>");
  alert(arrDate[0]+" "+monthOfBirth(birthDay.getMonth())+" "+birthDay.getFullYear());
}
// try .. catch

// 1.2. Make a function that takes date string as a parameter, and returns the Day
// name (Saturday, Sunday,) of the given date.

function dayOfBirth(myDate) {
  var arrOfDays = [
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
  ];
  return arrOfDays[myDate.getDay()];
}
