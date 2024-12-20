// 4.3. Write a function that takes any number of parameters and returns them reversed using
// array’s reverse function.

/**
 * take parameters and return them in reverse order
 * @returns array
 */
function reverseParameters()
{
    var arr=[];
    for(var i=0;i<arguments.length;i++)
        arr[i]=arguments[i]
    return arr.reverse();
}
console.log(reverseParameters(1,2,"abc",3,4,"def"))