console.log("Variables and it's Data types");
var name = "Java Script node js code";
var age = 40;
var city = "Delhi";

console.log(`Name : ${name} ,Age : ${age} ,City : ${city}`);
console.log("Arrow function example");

const add = (a, b) => a + b;
const sub = (a, b) => a - b;

console.log(`Addition of two numbers : ${add(4, 6)}, sub: ${sub(4, 6)}`);
console.log("Class Demo");

class Person {

  constructor(name, age, city) {
    this.name = name;
    this.age = age;
    this.city = city;
  }
  display() {
    console.log(`Name : ${this.name} ,Age : ${this.age} ,City : ${this.city}`);
  }
}

const person1 = new Person("Nitin", 40, "Delhi");
person1.display();

console.log("Map function");

const numbers = [4,5,6,78,50];

const doubled = numbers.map((num) => num * 2);
console.log(`${doubled}`);


class student
{
    sname = "Samiksha";
    sage = 22;

    #marks = 250;

    displayinfo()
    {
        console.log(`${this.sname}, ${this.sage}, ${this.#marks}`);
    }
}



