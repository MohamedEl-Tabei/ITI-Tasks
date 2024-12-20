// Fill an array of 3 elements from the user, and apply each of the following mathematical
// operations on it (+, *, /). Format the output as shown in Fig

var arr = [];
var count = 0;
var results = [0, 1, 1];

do {
  arr[count] = prompt("Enter in index" + count);
  count = isFinite(arr[count]) &&arr[count] ? count + 1 : count;
} while (count < 3);

for (var i = 0; i < 3; i++) {
  var str = "";
  for (var j = 0; j < 3; j++) {
    switch (i) {
      case 0:
        results[i] = results[i] + Number(arr[j]);
        str = str + "+" + arr[j];
        break;
      case 1:
        results[i] = results[i] * arr[j];
        str = str + "*" + arr[j];

        break;
      case 2:
        results[i] = results[i] / arr[j];
        str = str + "/" + arr[j];
        break;
    }
  }
  var txt = i == 0 ? "sum" : i == 1 ? "multiply" : "division";
  document.write(
    "<h1>" +
      "<span style='color:red'>" +
      txt +
      " of the 3 values </span>" +
      str.slice(1, str.length) +
      " = " +
      results[i] +
      "</h1>"
  );
}

// 3.2 Fill an array of 5 elements from the user, sort it in descending and ascending
// orders then display the output as shown in Fig

var arr=[1 ,10 ,2 ,20 , 5];

document.write("<h1><span style='color:red'>u've entered the values </span>"+arr+"</h1>")
document.write("<h1><span style='color:red'>u values after descinding </span>"+arr.sort((a,b)=>b-a)+"</h1>")
document.write("<h1><span style='color:red'>u values after ascending </span>"+arr.reverse()+"</h1>")