const email = (email) => {
  if (!email.length) throw "email is required";
  if (!/^[a-zA-Z][a-zA-Z0-9_-]*@[a-zA-Z]+\.[a-zA-Z]{2,}$/.test(email))
    throw "invalid email";
};

const phone = (phone) => {
  if (!phone.length) throw "phone is required";
  if (!/^[0][1][0125][0-9]{8}$/.test(phone)) throw "invalid phone";
};

const name = (name) => {
  if (!name.length) throw "name is required";
  if (!/^[a-zA-Z]+$/.test(name)) throw "invalid name";
};

module.exports = { email, name, phone };
