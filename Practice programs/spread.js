// array expansioni

let arr1 = [1, 2, 3, 4];
let arr2 = [...arr1];           // [1, 2, 3, 4] 
let arr3 = [arr1, 5, 6, 7, 8];  // [[1, 2, 3, 4], 5, 6, 7, 8]

console.log(arr1);
console.log(arr2);
console.log(arr3);

console.log(arr2.length);
console.log(arr1.length);
console.log(arr3.length);


// object expansion 
const obj1 = {a: 1, b: 2};      // {a: 1, b: 2}
const obj2 = {...obj1, c: 3};   // {a: 1, b: 2, c: 3}

console.log(obj1);
console.log(obj2);


// function expansion
function sum(a, b, c) {
    return a + b + c;
}

const num = [1, 2, 3];
console.log(sum(...num));

