//a- Display employees fullname and department name for all employees
db.employee.aggregate([
  {
    $lookup: {
      //join
      from: "department",
      localField: "department_id",
      foreignField: "department_id",
      as: "dept",
    },
  },
  {
    $project: {
      full_name: 1,
      "department name": {
        $arrayElemAt: ["$dept.department_description", 0],
      },
    },
  },
]);

//b- Display employees with position “VP Country Manager” (only display
//employee full name and salary).
db.employee.find(
  { position_title: "VP Country Manager" },
  {
    full_name: 1,
    salary: 1,
  }
);

//c- Display customers full names and their regions.

db.customer.aggregate([
  {
    $lookup: {
      from: "region",
      localField: "address.city",
      foreignField: "sales_city",
      as: "region",
    },
  },
  {
    $project: {
      region: {
        $arrayElemAt: ["$region.sales_region", 0],
      },
      fullName: {
        $concat: ["$fname", " ", "$lname"],
      },
    },
  },
]);

//d- In product find all products that was branded by " Washington "
//(try to createIndex on brand_name and test your query speed)

db.product.find({ brand_name: "Washington" });

db.product.dropIndex({ brand_name: 1 });
db.product.createIndex({ brand_name: 1 });

//a- Group products by brand name, count number and display the result

db.product.aggregate([
  {
    $group: {
      _id: {
        brand_name: "$brand_name",
      },
      count: {
        $sum: 1,
      },
    },
  },
  {
    $project: {
      _id: 0,
      brandName: "$_id.brand_name",
      count: 1,
    },
  },
]);

//b- Group products by brand_name and product_name ,only select brand
//names ("Blue Label","King","Washington") then sort them by brand_name and
//product_name ascending and display result as follow
db.product.aggregate([
  {
    $match: {
      brand_name: {
        $in: ["Blue Label", "King", "Washington"],
      },
    },
  },
  {
    $group: {
      _id: {
        brand_name: "$brand_name",
        product_name: "$product_name",
      },
    },
  },
  {
    $project: {
      _id: 0,
      brandName: "$_id.brand_name",
      productName: "$_id.product_name",
    },
  },
  {
    $sort: {
      productName: 1,
    },
  },
]);

//BONUS:Display maximum salary for each department (display department
// name and maximum salary)
db.employee.aggregate([
  {
    $group: {
      _id: {
        department_id: "$department_id",
      },
      max: {
        $max: "$salary",
      },
    },
  },
  {
    $lookup: {
      from: "department",
      localField: "_id.department_id",
      foreignField: "department_id",
      as: "department_name",
    },
  },
  {
    $project: {
      _id: 0,
      departmentName: {
        $arrayElemAt: ["$department_name.department_description", 0],
      },
      max: 1,
    },
  },
]);
