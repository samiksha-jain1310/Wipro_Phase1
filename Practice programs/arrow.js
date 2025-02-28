
// proper define function
/*
function sum(a, b) {
    return a+b;
}
*/

//local function 
let sum = function(a, b) {
    return a+b;
}


// arrow functions : only to define concise functions
let sum1 = (a, b) => {
    return a+b;
}

// 2nd type to define arrow function
let sum2 = (a, b) => a + b;


// single argument in arrow function
let square = a => a * a;


console.log(sum(4, 5));
console.log(sum1(6, 2));
console.log(sum2(2, 3));
console.log(square(3));

