//Selector
var paragraph=document.getElementById("PAR")

//Functions

var ChangeFont=function(font){
    paragraph.style.fontFamily=font;
}

var ChangeAlign=function(textAlign)
{
    paragraph.style.textAlign=textAlign;
}

var ChangeHeight=function(height){
    paragraph.style.height=height;
}

var ChangeLSpace=function(letterSpacing)
{
    paragraph.style.letterSpacing=letterSpacing
}

var ChangeIndent=function(textIndent){
    paragraph.style.textIndent=textIndent
}

var ChangeTransform=function(textTransform){
    paragraph.style.textTransform=textTransform
}

var ChangeDecorate=function(textDecoration){
    paragraph.style.textDecoration=textDecoration
}

var ChangeBorder=function(borderStyle){
    paragraph.style.borderStyle=borderStyle
}

var ChangeBorderColor=function(borderColor){
    paragraph.style.borderColor=borderColor
}