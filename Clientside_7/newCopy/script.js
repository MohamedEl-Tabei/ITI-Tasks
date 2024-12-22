//Selectors
var firstDiv=document.getElementsByClassName("first-div")[0]

//Handler
/**
 * event handler to add new copy of div
 * @param {object} event 
 */
var onclickHandler=function(event){
    var first=event.target;
    var newCopy=first.cloneNode()
    var container=document.getElementsByClassName("container")[0]
    newCopy.style.backgroundColor="#"+Math.random().toString().slice(3,9)
    newCopy.innerText="sub"
    container.append(newCopy)
}


firstDiv.addEventListener("click",onclickHandler)
