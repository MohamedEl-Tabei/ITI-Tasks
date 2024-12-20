// 4.2. Write your own function that can add n values ensure that all passing parameters are
// numerical values only. 

/**
 * take  n values of parameters and return their sum
 * @returns number
 */

function sumValues(){
    var sum=0;
    for(var i=0;i<arguments.length;i++)
    {
        if(typeof arguments[i] !="number")
        {
            throw "sumValues only accept numric values"
        }
        else{
            sum=arguments[i]+sum;
        }
    }
    return sum;
}
console.log("sum is "+sumValues(1,2,3))
console.log("sum is "+sumValues(1,2,"3"))