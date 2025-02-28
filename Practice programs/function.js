function greeting()
{
    console.log('Welcome to our app.');
}


greeting();
//greeting();
//greeting();
//greeting();
//greeting();


//function calling using return statment
function isPrime()
{
    return 7;
    console.log('After return');
}

let prime = isPrime();
console.log(prime);



function sum(a, b)  // parameters 
{
    let add = a + b;
    return add;
}
let result = sum(5, 5); // arguments 
console.log(result);