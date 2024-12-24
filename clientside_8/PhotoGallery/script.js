var arr=["imgs/emoji_1.png","imgs/emoji_2.png","imgs/emoji_3.png","imgs/emoji_4.png","imgs/emoji_5.png"]
var interval
var counter=0
//selectors
var img=document.getElementById("image")
var nextBtn=document.getElementById("next")
var prevBtn=document.getElementById("previos")
var startBtn=document.getElementById("start")
var stopBtn=document.getElementById("stop")
////////////////////////////////////////////





stopBtn.addEventListener("click",function(){
    clearInterval(interval);
})

startBtn.addEventListener("click",function(){
    interval= setInterval(function(){
        counter=counter<arr.length-1?counter+1:0;
        img.setAttribute("src",arr[counter]);
    },2000)
})


prevBtn.addEventListener("click",function(){
    counter=counter>0?counter-1:counter
    img.setAttribute("src",arr[counter]);

})


nextBtn.addEventListener("click",function(){
    counter=counter<arr.length-1?counter+1:counter
    img.setAttribute("src",arr[counter]);

})