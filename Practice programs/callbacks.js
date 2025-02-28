// define a callback function 
function greeting()
{
    console.log(`Hello ${name1}`);
}


// define a function that takes a callback 
function getUserInput(callback)
{
    var name1 = prompt("Please enter you name: ");
    callback(name1);
}


// call the function with the call back 
getUserInput(greeting);