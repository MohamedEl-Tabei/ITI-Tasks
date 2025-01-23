//6- start create new collection named instructors and start with following inserts
db.createCollection("instructors");

let instructorsArray = [
  {
    _id: 6,
    firstName: "noha",
    lastName: "hesham",
    age: 21,
    salary: 3500,
    address: { city: "cairo", street: 10, building: 8 },
    courses: ["js", "mvc", "signalR", "expressjs"],
  },

  {
    _id: 7,
    firstName: "mona",
    lastName: "ahmed",
    age: 21,
    salary: 3600,
    address: { city: "cairo", street: 20, building: 8 },
    courses: ["es6", "mvc", "signalR", "expressjs"],
  },

  {
    _id: 8,
    firstName: "mazen",
    lastName: "mohammed",
    age: 21,
    salary: 7040,
    address: { city: "Ismailia", street: 10, building: 8 },
    courses: ["asp.net", "mvc", "EF"],
  },

  {
    _id: 9,
    firstName: "ebtesam",
    lastName: "hesham",
    age: 21,
    salary: 7500,
    address: { city: "mansoura", street: 14, building: 3 },
    courses: ["js", "html5", "signalR", "expressjs", "bootstrap"],
  },

  {
    _id: 10,
    firstName: "badr",
    lastName: "ahmed",
    age: 22.0,
    salary: 5550.0,
    address: {
      city: "cairo",
      street: 10.0,
      building: 8.0,
    },
    courses: ["sqlserver", "mvc", "signalR", "asp.net"],
  },
  {
    _id: 2,
    firstName: "mona",
    lastName: "mohammed",
    age: 21.0,
    salary: 3600.0,
    address: {
      city: "mansoura",
      street: 20.0,
      building: 18.0,
    },
    courses: ["es6", "js", "mongodb", "expressjs"],
  },
  {
    _id: 3,
    firstName: "mazen",
    lastName: "ali",
    age: 30.0,
    salary: 7010.0,
    address: {
      city: "cairo",
      street: 10.0,
      building: 5.0,
    },
    courses: ["asp.net", "mvc", "EF"],
  },
  {
    _id: 4,
    firstName: "ebtesam",
    lastName: "ahmed",
    age: 28.0,
    salary: 6200.0,
    address: {
      city: "mansoura",
      street: 14.0,
      building: 7.0,
    },
    courses: ["js", "html5", "signalR", "expressjs", "bootstrap", "es6"],
  },
];
//a- Insert many using array contained with lab folder instructors.txt file.
db.instructors.insertMany(instructorsArray);
//b- Insert your own data
db.instructors.insertOne({
  firstName: "mohamed",
  lastName: "eltabei",
  age: 24.0,
  address: "Portsaid",
  courses: "JS",
});
//c- Insert instructor without firstName and LastName (mongo will raise an error or not ?)

db.instructors.insertOne({
  age: 24.0,
  address: "Portsaid",
  courses: "JS",
});

//7- Try the following queries: (all queries should be run using find or findOne)
//a- db.instructors.find({});
db.instructors.find({});
//b- db.instructors.find();
db.instructors.find();
//c- db.instructors.findOne();
db.instructors.findOne();
//d- db.instructors.find().constructor.name
db.instructors.find().constructor.name;
//e- db.instructors.find({}).forEach((document)=>{
//print(document);
//})

db.instructors.find({}).forEach((document) => print(document));
//f-Now from step e try to display only firstName and lastName for each
//instructor?!
db.instructors.find({}).forEach((instractor) => {
  print(instractor.firstName, instractor.lastName);
});

//h-Then - max and min salary for all instructors.
let max = 0;
let min = 0;
let count = 0;
let sum = 0;
db.instructors.find({}).forEach((instructor) => {
  max = instructor.salary > max ? instructor.salary : max;
  min = instructor.salary < min || count == 0 ? instructor.salary : min;
  count++;
  sum = instructor.salary ? sum + instructor.salary : sum;
  print(typeof instructor.salary);
});
print(max, min, sum / count);
