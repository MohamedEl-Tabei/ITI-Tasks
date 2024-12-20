// Math.random() guess game + validation `bonus`
/**
 * Function to play guess a number game from 0-9
 */
var guessGame = function () {
  var num;
  var random = Math.random().toString()[5];
  do {
    num = prompt("guess number from 0-9");
    num = num == "" ? -1 : num;
    if (num < random && num >= 0) alert("Lower");
    else if (num > random && num <= 9) alert("Greater");
    else if (num !== random) alert("Invalid Number");
  } while (num != random);

  document.write("<h1 style='color:green;text-align:center'>Winner</h1>");
};
//guessGame();

// Math.random() within range from 5 - 10 `bonus`
/**
 * Function to play guess a number game from 5-10
 */
var guessGame_5_10 = function () {
  var num;
  var random = Number(Math.random().toString()[5]);
  random = random < 5 ? random + 6 : random;
  do {
    num = prompt("guess number from 5-10");
    num = num == "" ? -1 : num;
    if (num < random && num >= 5) alert("Lower");
    else if (num > random && num <= 10) alert("Greater");
    else if (num != random) alert("Invalid Number");
  } while (num != random);

  document.write("<h1 style='color:green;text-align:center'>Winner</h1>");
};
guessGame_5_10();
