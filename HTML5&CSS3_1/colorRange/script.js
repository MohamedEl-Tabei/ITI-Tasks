var selectors={
    redRange:document.getElementById("red"),
    greenRange:document.getElementById("green"),
    blueRange:document.getElementById("blue"),
    paragraph:document.querySelector("p")
}
var labelSelectorsForValue={
    red:document.getElementById("redValue"),
    green:document.getElementById("greenValue"),
    blue:document.getElementById("blueValue")
}
var colors={
    red:0,
    green:0,
    blue:0
}

var onInputHandler=function(){
    colors[this.id]=this.value;
    labelSelectorsForValue[this.id].innerText=this.value
    selectors.paragraph.style.color="rgb("+colors.red+","+colors.green+","+colors.blue+")"
}



selectors.redRange.addEventListener("input",onInputHandler)
selectors.blueRange.addEventListener("input",onInputHandler)
selectors.greenRange.addEventListener("input",onInputHandler)