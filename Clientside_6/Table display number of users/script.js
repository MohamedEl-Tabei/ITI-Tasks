var arr = [];
var numberOfUsers;
var i = 0;
var user = { name: "", age: 0 };
//take number of users from user
do {
  numberOfUsers = prompt("Enter the no of users:");
} while (isNaN(numberOfUsers)||!numberOfUsers);

//push users to the arr
while (i < numberOfUsers) {
  i++;
  do {
    user.name = prompt("enter user " + i + " name:");
  } while (
    !(user.name.length >= 3 && user.name.length <= 10) ||
    !/^[a-zA-Z]+$/.test(user.name)
  );
  do {
    user.age = prompt("enter user " + i + " age:");
  } while (!(user.age >= 10 && user.age <= 60) || isNaN(user.age));
  arr.push({name:user.name,age:user.age});
}

//tbody
var tbody = document.getElementById("container");

arr.forEach(function (user) {
  var tr = document.createElement("tr");
  tr.innerHTML = "<td>" + user.name + "</td>" + "<td>" + user.age + "</td>";
  tbody.append(tr);
});

if(arr.length)
    document.getElementsByTagName("table")[0].style.visibility="visible"