// - Object
//     1. write a script that allows you to create a rectangle object that
    
//     • Should have width and height properties.
//     • Implement two methods for calculating its area and perimeter return value.
//     • Implement displayInfo() function to display a message declaring the width, height,
//     area and perimeter of the created object.


var rectangle={
    width:185,
    height:154,
    area:function(){
        return this.width*this.height;
    },
    perimeter:function(){
        return 2*(this.width+this.height);
    },
    displayInfo:function(){
        return "width= "+this.width +", height= "+this.height+", area= "+this.area()+", perimeter= "+this.perimeter();
    }
}

console.log(rectangle.area());
console.log(rectangle.perimeter());
console.log(rectangle.displayInfo());
document.write("<div style='background-color:green;width:"+rectangle.width+"px; height:"+rectangle.height+"px'"+"</div>")

