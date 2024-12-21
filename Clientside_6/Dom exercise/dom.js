//body
document.body.style.margin="0px"

//container (center)
var container=document.getElementsByClassName("center")[0]
container.style.height="100vh"
container.style.display="flex"
container.style.flexDirection="column"
container.style.justifyContent="space-between"



//Header
var header=document.getElementById("header");
header.style.display="flex";
header.style.justifyContent="end"

//Footer
var footer=document.createElement("div");
footer.style.display="flex";
footer.style.justifyContent="start"
footer.innerHTML="<img src='"+header.children[0].getAttribute("src")+"'/>"
container.append(footer);


//navigation
var navigation=document.getElementById("navigation");
navigation.style.display="flex"
navigation.style.justifyContent="center"

//nav
var nav=document.getElementById("nav")
nav.setAttribute("type","circle")



