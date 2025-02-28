// promisesExample.js

function fetchData() {
    //create a promise function to with timeout of 1 second to return data 'Data from server'
    return new Promise((resolve) => {
      setTimeout(() => {
        resolve('Data from server');
      }, 1000);
    });
  
    }
    
    module.exports = fetchData;