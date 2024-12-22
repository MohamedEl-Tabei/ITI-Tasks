//Selectors
var inputAnswer = document.getElementById("Answer");
inputAnswer.style.width="100%"

//variables
var text = "";
var result = "";
var lastInput;

//Functions

/**
 * take number and concate with global text
 * @param {string} value 
 */
var EnterNumber = function (value) {
  text = text == "Error"||result ? value : text + value;
  lastInput=value;
  result = "";
  inputAnswer.value = text;
};

/**
 * take operator and concate with global text
 * @param {string} value 
 */
var EnterOperator = function (value) {
  text = isNaN(lastInput)?  text:text + value;
  lastInput = isNaN(lastInput)?  lastInput:value;
  result=""
  inputAnswer.value = text;
};

/**
 * clear global text ("")
 */
var EnterClear = function () {
  text = "";
  inputAnswer.value = text;
};

/**
 * call built in eval to get result and set it to global result
 */
var EnterEqual = function () {
  result =  isNaN(lastInput)?"Error":eval(text);
  result = isNaN(result) || result == Infinity  ? "Error" : result;
  text = result;
  inputAnswer.value = text;
};
