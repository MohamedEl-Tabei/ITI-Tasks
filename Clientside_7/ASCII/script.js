document.body.addEventListener("keydown",function(e){
    if(e.keyCode!==18&&e.keyCode!==17&&e.keyCode!==16) alert(e.keyCode+"\n"+"is Alt: "+e.altKey+"\nis shift: "+e.shiftKey+"\nis ctr: "+e.ctrlKey)
   
})