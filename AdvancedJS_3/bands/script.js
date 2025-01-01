var data;
var memberWeb;
var selectors = {
  loader: document.querySelector(".loader"),
  band: document.getElementById("band"),
  members: document.getElementById("members"),
};
var xhr = new XMLHttpRequest();
xhr.open("get", "data.json");
xhr.send();

xhr.addEventListener("readystatechange", function (event) {
  if (event.target.readyState == 4) {
    selectors.members.disabled = true;
    selectors.loader.style.display = "none";
    var response = event.target.response;
    data = JSON.parse(response);
    for (var bandName in data) {
      var option = document.createElement("option");
      option.value = bandName;
      option.innerText = bandName;
      selectors.band.append(option);
    }
  }
});
selectors.band.addEventListener("change", function (event) {
  selectors.members.innerHTML = "";
  selectors.members.disabled = false;
  data[event.target.value].forEach(function (member) {
    var option = document.createElement("option");
    option.value = member.value;
    option.innerText = member.name;
    selectors.members.append(option);
  });
});

selectors.members.addEventListener("change", function (event) {
  open(event.target.value);
});
