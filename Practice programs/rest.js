
// funcitons parameters 
function sum(...numbers) {
    return numbers.reduce((acc, curr) => acc + curr, 0)
}

console.log(sum(1, 2, 3));      // 6

// Array de-structuring 
const [first, second, ...rest] = [1, 2, 3, 4, 5, 6];
console.log(first);
console.log(second);
console.log(rest);

// object de-structuring 
const { a, b, ...rest1 } = { a: 1, b: 2, c: 3, d: 4 };
console.log(rest1);

