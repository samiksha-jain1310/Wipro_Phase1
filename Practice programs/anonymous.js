function greeting()
{
    console.log('Hello my name is samiksha.');
}

console.log('Before');

setTimeout(greeting, 5000);

console.log('After');


console.log('Before');
setTimeout(function() {
    console.log('i am anonymous functions. ');
}, 3000);
console.log('After');


const multiply = function(a, b) {
    return a * b;
}

console.log(multiply(4, 3));

