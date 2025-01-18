// Question: Create a function that takes literal types "red" | "yellow" | "blue" and returns their hexcode colors

type Color = "Red"|"Yellow"|"Blue";

function getColorCode(color: Color): string {
    const colors = {
        Red:"#f44336",
        Yellow:"#ffeb3b",
        Blue:"#3b4fff"
    }

    return colors[color];

}

// console.log(getColorCode("Yellow"));

// Write a function printValueLength that accepts a parameter of type string | string[], string | number[], ...etc. Use type narrowing to safely log the length of the value. (Don't use any)
type MyType={length:number}
function printValueLength(value: MyType): void {
    console.log(value.length)
}

printValueLength("hello"); // "String length: 5"
printValueLength(["a", "b", "c"]); // "Array length: 3"
printValueLength([1, 2]); // "Array length: 2"
printValueLength([{ name: "Ali" }, { name: "Mohammed" }, { name: "Mostafa" }]); // "Array length: 3"


// Write a generic class Storage<T> that holds an array of items of type T. Add methods to add items and get all items.

class MyStorage <T>{
    private items:T[];
    constructor(){
        this.items= new Array<T>();
    }
    addItem(item:T) {
        this.items.push(item)
    }
    getItems(){
        return[...this.items]
    }
}
const stringStorage = new MyStorage<string>();
stringStorage.addItem("hello");
console.log(stringStorage.getItems()); // ["hello"]


// Given the data, define the interface "User" and use it accordingly.

interface User{
    id:number|string,
    name:string,
    role:"SUPER_ADMIN"|"USER"|"ADMIN",
    age?:number
}

const users: User[] = [
  {
    id: 1,
    name: "Ahmed",
    role: "SUPER_ADMIN",
  },
  {
    id: "2",
    name: "Mohammed",
    age: 32,
    role: "USER",
  },
  {
    id: 3,
    name: "Ali",
    age: 36,
    role: "ADMIN",
  },
];
console.log(users);


// Create a new type "BlogSummary" that only inherit the "title" and "author" properties from the Blog interface.

interface Blog {
    id: number;
    title: string;
    content: string;
    author: string;
  }
  
  type BlogSummary = Pick<Blog,"title"|"author"> ; // <- update this
  
  const summary: BlogSummary = { title: "TypeScript Tips", author: "Alice" };
  
  
// Create a new type "PublicUser" that execlude the propery "password" from "SystemUser"

interface SystemUser {
    id: number;
    name: string;
    email: string;
    password: string;
  }
  
  type PublicUser = Omit<SystemUser,"password">;
  
  const publicUser: PublicUser = {
    id: 1,
    name: "John",
    email: "john@example.com",
  };
  

  
// Implement the built it Required utlity type (hint: with mapped types)
type Todo = {
    id: string;
    title: string;
    description?: string;
  };
  
  type MyRequired<T>= {
    [key in keyof T]-?: T[key]
  } //<- here
  
  type TodoAllRequired = MyRequired<Todo>;
  const list:TodoAllRequired={
    id:"5",
    title:"5",
    description:"4"

  }
  
  
