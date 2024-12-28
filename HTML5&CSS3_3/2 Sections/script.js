var selectors = {
  container1: document.getElementById("container1"),
  container2: document.getElementById("container2"),
};

var contant = [
  { head: "Fresh and Clean", icon: "fa-bullhorn" },
  { head: "Retina ready", icon: "fa-comments" },
  { head: "Easy to customize", icon: "fa-cloud-download" },
  { head: "Adipisicing elit", icon: "fa-leaf" },
  { head: "Sed do elusmod", icon: "fa-cogs" },
  { head: "Labore et dolore", icon: "fa-heart" },
];

contant.forEach(function (element) {
  var card = document.createElement("div");
  card.className = "card";
  card.innerHTML = `<div class="icon-container">
                        <i class="fa ${element.icon}"></i>
                    </div>
                    <div>
                        <h4>${element.head}</h4>
                        <small>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </small>
                    </div>`;
  selectors.container1.append(card);
});

for (var i = 1; i < 7; i++) {
  var div = document.createElement("div");
  div.className = "img-container";
  div.innerHTML = `  <img src="images/${i}.jpg"/> 
                     <h2>Head ${i}</h2>   
                     <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloremque
                        totam atque eveniet deserunt hic itaque veniam dolores quis, nemo,
                        maiores eaque culpa veritatis sapiente architecto vitae, incidunt
                        debitis possimus molestiae?
                    </p>           
  `;
  selectors.container2.append(div);
}
