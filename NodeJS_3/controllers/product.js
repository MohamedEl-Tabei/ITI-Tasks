const getProduct = (req, res) => {
  res.send("get product");
};

const postProduct = (req, res) => {
  res.send(`post product`);
};

module.exports = {
  getProduct,
  postProduct,
};
