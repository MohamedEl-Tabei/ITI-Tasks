var tasks = [];
function Task(n) {
  this.name = n || "";
  this.checked = false;
}
$("form").submit(function (e) {
  e.preventDefault();
  var value = $("#task").val();
  if (value) {
    var newTask = new Task(value);
    tasks.push(newTask);
    display();
  }
  $("#task").val("");
});

function display() {
  $("tbody").html("");
  tasks.forEach(function (task, i) {
    $("tbody").append(
      "<tr><td> " +
        "<div>" +
        "<input type='checkbox'  id='" +
        i +
        "' " +
        (task.checked ? "checked" : "") +
        "> " +
        "<label for='" +
        i +
        "' >" +
        task.name +
        "</label>" +
        "</div>" +
        "<i class='fa-solid fa-trash " +
        (!task.checked ? "d-none" : "") +
        "'></i></td></tr>"
    );
    $("#" + i).change(function () {
      tasks[i].checked = this.checked;
      var trash = $($("#" + i).parent()).next()[0];
      trash.classList.toggle("d-none");
    });
    $($($("#" + i).parent()).next()[0]).click(function () {
      tasks.splice(i, 1);
      display();
    });
  });
}
