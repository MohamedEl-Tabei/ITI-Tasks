const checkLists = [];
let products = [];
async function getData() {
  const response = await fetch("https://fakestoreapi.in/api/products");
  let data = await response.json();
  const categories = new Set();
  products = data.products;
  products.forEach((product) => categories.add(product.category));
  categories.forEach((category) => addCategory(category));
  displayProducts();
}
getData();

const addCategory = (category) => {
  let formCheck = document.createElement("div");
  formCheck.className = "form-check";
  formCheck.innerHTML = `<input class="form-check-input" type="checkbox" value="" id=${category} >
  <label class="form-check-label" for=${category}>
    ${category}
  </label>`;
  formCheck.firstChild.addEventListener("change", () =>
    onChangeHandler(category)
  );
  const sideBar = document.getElementById("sideBar");
  sideBar.append(formCheck);
};

const onChangeHandler = (category) => {
  const index = checkLists.indexOf(category);
  if (index >= 0) {
    checkLists.splice(index, 1);
  } else checkLists.push(category);
  console.log(checkLists);

  displayProducts();
};

function displayProducts() {
  const productsDisplay = checkLists.length
    ? products.filter((product) => checkLists.includes(product.category))
    : products;
  document.getElementById("productsContainer").innerHTML = "";
  productsDisplay.forEach((product) => {
    const card = document.createElement("div");
    card.className = "card shadow";
    card.innerHTML = `
    <img src="${product.image}" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">${product.price}$</h5>
      <p class="card-text">${product.title}</p>
      <p class="card-text"><small class="text-body-secondary">${product.category}</small></p>
    </div>
  `;
    document.getElementById("productsContainer").append(card);
  });
}

document.getElementById("sort").addEventListener("change", function () {
  products.sort((a, b) => a.price - b.price);
  if (this.value == "ascending") {
    displayProducts(products);
  } else displayProducts(products.reverse());
});
