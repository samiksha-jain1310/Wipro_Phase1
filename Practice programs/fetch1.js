async function fetchData(url) {
    try {
        const response = await fetch(url);
        if(!response.ok) {
            throw new Error('Network response was not ok ' +response.statusText);
        }
        const data = await response.json();
        console.log(data);
    } catch (error) {
        console.log(error);
    }
}


fetchData('https://jsonplaceholder.typicode.com/posts');

