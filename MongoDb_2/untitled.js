//a- Display all documents in instructors collection
db.instructors.find();

//b- Display all instructors with salaries greater than 4000 (only show
//firstName and salary)
db.instructors.find(
  {
    salary: {
      $gt: 4000,
    },
  },
  { firstName: 1, salary: 1, _id: 0 }
);

//c- Display all instructors with ages less than or equal 25.
db.instructors.find({
  age: {
    $lte: 25,
  },
});

//d- Display all instructors with city mansoura and sreet
// number 10 or 14 only display (firstname,address,salary).
db.instructors.find(
  {
    "address.city": "mansoura",
    $or: [{ "address.street": 10 }, { "address.street": 14 }],
  },
  {
    firstName: 1,
    address: 1,
    salary: 1,
    _id: 0,
  }
);

//e- Display all instructors that have js and jquery in their courses
// (both of them not one of them).
db.instructors.find({
  $and: [{ courses: "js" }, { courses: "jquery" }],
});

//f- Display number of courses for each instructor and display first
//name with number of courses.

db.instructors
  .find(
    {},
    {
      firstName: 1,
      courses: 1,
    }
  )
  .forEach((document) => print(document.firstName, document.courses.length));

//g- Write mongodb query to get all instructors that have firstName and
//lastName properties , sort them by firstName ascending then by
//lastName descending and finally display their data FullName and age
//Note: use mongoDB sort function

db.instructors
  .find(
    {
      firstName: {
        $exists: true,
      },
      lastName: {
        $exists: true,
      },
    },
    {
      firstName: 1,
      lastName: 1,
      age: 1,
    }
  )
  .sort({ firstName: 1, lastName: -1 });

//h- Delete instructor with first name “ebtesam” and has only 5 courses in
//courses array
db.instructors.deleteOne({
  firstName: "ebtesam",
  courses: {
    $size: 5,
  },
});

//i- Add active property to all instructors and set its value to true.
db.instructors.updateMany(
  {},
  {
    $set: {
      active: true,
    },
  }
);

//j- Change “EF” course to “jquery” for “mazen mohammed” instructor
//(without knowing EF Index in courses array)

db.instructors.updateOne(
  { firstName: "mazen", lastName: "mohammed", courses: "EF" },
  {
    $set: {
      "courses.$": "jquery",
    },
  }
);

//k- Add jquery course for “noha hesham”.

db.instructors.updateOne(
  {
    firstName: "noha",
    lastName: "hesham",
  },
  {
    $push: {
      courses: "jquery",
    },
  }
);

//l- Remove courses property for “ahmed mohammed ” instructor
db.instructors.updateOne(
  {
    firstName: "ahmed",
    lastName: "mohammed",
  },
  {
    $unset: {
      courses: [],
    },
  }
);

//db.instructors.deleteMany({
//    firstName:"ahmed",
//    lastName:"mohammed"
//}
//)
//db.instructors.find()
//db.instructors.insertOne(
//{
//    firstName:"ahmed",
//    lastName:"mohammed",
//    "age" : NumberInt(24),
//    "address" : "Portsaid",
//    "courses" : ["JS","EF"],
//    "active" : true
//}
//)

//
//m- Decrease salary by 500 for all instructors that has only 3 courses in their
//list ($inc)

db.instructors.updateMany(
  {
    courses: {
      $size: 3,
    },
  },
  {
    $inc: {
      salary: -500,
    },
  }
);

//n- Rename address field for all instructors to fullAddress.
db.instructors.updateMany(
  {},
  {
    $rename: {
      address: "fullAddress",
    },
  }
);

db.instructors.find();

//o- Change street number for noha hesham to 20
db.instructors.updateOne(
  {
    firstName: "noha",
    lastName: "hesham",
  },
  {
    $set: {
      "fullAddress.street": 20,
    },
  }
);
