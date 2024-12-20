// 4.1. Create a function that accepts only 2 parameters and throw exception if number of
// parameters either less than or exceeds 2 parameters.

/**
 * take only two parameters
 * @param {*} x 
 * @param {*} y 
 */

function only2Parameters(x,y)
{
    if(arguments.length!=2)
        throw "Enter two parameters."
    else 
        console.log("Two parameters are "+x+" & "+y);
}


only2Parameters(5,6)
only2Parameters(5)