// - Task2
    
//     On your page, show alert for the user that say “Welcome to my site”, then show him
//     prompt ask him to enter his name The user has to choose either (red, green or blue
//     color), take his choice via prompt and write to the page “welcome + his name”

var userName;
var color;
alert("Welcome to my site");

do{
    userName=prompt("Please Enter Your Name.");

}while(!isNaN(userName))
do{
    color=prompt("Please Choose Color [red,green,blue]") ||"orange";
}while(!(color!="red"||color!="green"||color!="blue"));

document.write("<h1 style='color:"+color+"'>Welcome "+userName+"</h1>")

/**
 *JS DOC
 * @param
 * @returns  
*/
