"use strict";
// Question: Create a function that takes literal types "red" | "yellow" | "blue" and returns their hexcode colors
function getColorCode(color) {
    const colors = {
        Red: "#f44336",
        Yellow: "#ffeb3b",
        Blue: "#3b4fff"
    };
    return colors[color];
}
function printValueLength(value) {
    console.log(value.length);
}
printValueLength("hello"); // "String length: 5"
printValueLength(["a", "b", "c"]); // "Array length: 3"
printValueLength([1, 2]); // "Array length: 2"
printValueLength([{ name: "Ali" }, { name: "Mohammed" }, { name: "Mostafa" }]); // "Array length: 3"
// Write a generic class Storage<T> that holds an array of items of type T. Add methods to add items and get all items.
class MyStorage {
    constructor() {
        this.items = new Array();
    }
    addItem(item) {
        this.items.push(item);
    }
    getItems() {
        return [...this.items];
    }
}
const stringStorage = new MyStorage();
stringStorage.addItem("hello");
console.log(stringStorage.getItems()); // ["hello"]
const users = [
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
const summary = { title: "TypeScript Tips", author: "Alice" };
const publicUser = {
    id: 1,
    name: "John",
    email: "john@example.com",
};
const list = {
    id: "5",
    title: "5",
    description: "4"
};
