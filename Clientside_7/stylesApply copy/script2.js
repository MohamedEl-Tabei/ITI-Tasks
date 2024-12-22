//Selectors
var table = document.getElementById("Text");
var paragraph=document.getElementById("PAR")


table.addEventListener("click", function (event) {
  var targetName = event.target.name;
  var value=event.target.value;
  
  switch (targetName) {
    case "Font":
        paragraph.style.fontFamily=value
      break;
    case "Align":
        paragraph.style.textAlign=value
        break;
    case "Height":
        paragraph.style.height=value
        break;
    case "Lspace":
        paragraph.style.letterSpacing=value
        break;
    case "Indent":
        paragraph.style.textIndent=value
        break;
    case "Transform":
        paragraph.style.textTransform=value
        break;
    case "Decorate":
        paragraph.style.textDecoration=value
        break;
    case "Border":
        paragraph.style.borderStyle=value
        break;
    case "BorderColor":
        paragraph.style.borderColor=value
        break;
    default:
      break;
  }
});
