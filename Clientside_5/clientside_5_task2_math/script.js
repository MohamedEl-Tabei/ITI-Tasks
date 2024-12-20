// 2.1 Write a script that ask the user to Enter the value of a circle’s radius in order to calculate
// its area.

/**
 * function get value from user to calculate circle's area
 */

var circleArea=function(){
    var r;
    do {
        r=prompt("Please enter a radius");
    } while (isNaN(r));

    document.write("<h1>circle’s area = "+Math.pow(r,2)*Math.PI+"</h1>")
}

circleArea()



// 2.2 Enter another value to calculate its square root and alert the result.

/**
 * function get value from user to calculate its square root 
 */
var squareRoot=function(){
    var num;
    do {
        num=prompt("Please enter a number");
    } while (isNaN(num));

    alert(Math.sqrt(num))

}

squareRoot();