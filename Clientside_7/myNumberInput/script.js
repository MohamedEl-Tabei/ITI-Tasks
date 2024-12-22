var input= document.getElementById("id")
var value=input.value
input.addEventListener("input",function(event){
    if(!/^[1-9]$/.test(event.data))
        input.value=value
    value=input.value
})