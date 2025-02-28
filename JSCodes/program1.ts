
/*
const names : string[] = [];
names.push("Samiksha");
names.push("Kaju");
console.log(names);


const names1 : any[] = [];
names1.push("Samiksha");
names1.push(13);
console.log(names1);


const num : number[] = [4, 6, 8, 10];
console.log(num);
console.log(num[3]);

*/

//Tuple: Tuples types array with predefined length and types for each index

/*
let myTuple : [number, string, boolean];

myTuple = [45, "Typescript is a superset of Javascript", true];
console.log(myTuple);
*/

//Named Tuple :

const graph : [x: number, y: number] = [550.34, 50.32];

console.log(graph);


const book: { name: string, price: number, publisher?: string } = {
  
  name: "typescript programming",
  price:  400,
 
};