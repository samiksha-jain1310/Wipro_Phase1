function step1(callback) {
    setTimeout(() => {
        console.log('Step 1');
        callback();
    }, 1000);
}

function step2(callback) {
    setTimeout(() => {
        console.log('Step 2');
        callback();
    }, 1000);
}


function step3(callback) {
    setTimeout(() => {
        console.log('Step 3');
        callback();
    }, 1000);
}


step1(() => {
    step2(() => {
        step3(() => {
            console.log('All the steps are completed. ')
        });
    });
});


/* this version, each step, returns a promise that resolve after a timeout. the steps 
    are chained together using .then(), making the code more readable and easier to 
    maintain.
*/ 

step1()
    .then( () => step2())
    .then( () => step3())
    .then( () => {
        console.log('All the steps are completed. ');
    });



