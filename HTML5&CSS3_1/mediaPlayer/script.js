var selectors={
    audio:document.querySelector("audio"),
    time:document.getElementById("time"),
    play:document.getElementById("play"),
    puase:document.getElementById("pause"),
    stop:document.getElementById("stop"),
    mute:document.getElementById("mute"),
    img:document.querySelector("img")
}
window.addEventListener("load",function(){
    selectors.time.setAttribute("max",selectors.audio.duration.toFixed())
    
})

selectors.audio.addEventListener("timeupdate",function(){
    selectors.time.value= this.currentTime
})
selectors.time.addEventListener("input",function(){
    selectors.audio.currentTime=this.value
})
selectors.play.addEventListener("click",function(){
    selectors.audio.play()

    selectors.time.setAttribute("max",selectors.audio.duration.toFixed())

})
selectors.puase.addEventListener("click",function(){
    selectors.audio.pause()
})
selectors.stop.addEventListener("click",function(){
    selectors.audio.pause()
    selectors.audio.load()
})
selectors.mute.addEventListener("click",function(){
    selectors.audio.muted=!selectors.audio.muted
    this.style.textDecoration=selectors.audio.muted?"line-through":"none"
})
//////////////
var onclickHandler=function(){
    selectors.audio.setAttribute("src","audios/"+this.id+".mp3")
    selectors.img.setAttribute("src","images/"+this.id+".jpg")
}

document.getElementById("cat").addEventListener("click",onclickHandler)
document.getElementById("dog").addEventListener("click",onclickHandler)
document.getElementById("elephant").addEventListener("click",onclickHandler)
document.getElementById("whale").addEventListener("click",onclickHandler)